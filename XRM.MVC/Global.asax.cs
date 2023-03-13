using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using XRM.Application._3_AutoMapper;
using XRM.Application._9_Geral;

namespace XRM.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();

            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
        }
    }
}
