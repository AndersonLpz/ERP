using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.OwinHost;
using Owin;
using System.Reflection;
using System.Web;
using XRM.Infra.CrossCutting.Identity._0_Context;
using XRM.Infra.CrossCutting.Identity._1_Configuration;
using XRM.Infra.CrossCutting.Identity._2_Model;
using XRM.Infra.CrossCutting.IoCNinject._0_Context;

[assembly: OwinStartupAttribute(typeof(XRM.MVC.Startup))]
namespace XRM.MVC
{
    public partial class Startup
    {
        private IAppBuilder _app;
        /// <summary>  
        /// Ninject kernel for injection.  
        /// </summary>  
        private IKernel kernel = null;
        public void Configuration(IAppBuilder app)
        {
            _app = app;
            kernel = CreateKernel();
            app.UseNinjectMiddleware(() => kernel);
            ConfigureAuth(app);
        }

        /// <summary>  
        /// Creates the kernel.  
        /// </summary>  
        /// <returns></returns>  
        public IKernel CreateKernel()
        {
            var objXRMNinject = new XRMNinject();
            var kernel = objXRMNinject.Kernel;
            try
            {
                kernel.Load(Assembly.GetExecutingAssembly());

                kernel.Bind<ApplicationDbContext>().ToSelf().InRequestScope();
                kernel.Bind<IUserStore<ApplicationUser>>().To<ApplicationUserStore>();
                kernel.Bind<ApplicationUserManager>().ToSelf();
                kernel.Bind<ApplicationSignInManager>().ToSelf();
                kernel.Bind<IAuthenticationManager>().ToMethod(x => HttpContext.Current.GetOwinContext().Authentication);
                kernel.Bind<IDataProtectionProvider>().ToMethod(x => _app.GetDataProtectionProvider());
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
    }
}