using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;
using XRM.Infra.CrossCutting.IoCNinject._1_EntityConfig;

namespace XRM.Infra.CrossCutting.IoCNinject._0_Context
{
    public class XRMNinject
    {
        public IKernel Kernel { get; private set; }

        public XRMNinject()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }
        public StandardKernel GetNinjectModules()
        {
            return new StandardKernel(
                new ApplicationNinject(),
                new DomainInfraNinject(),
                new DomainNinject());
        }
    }
}
