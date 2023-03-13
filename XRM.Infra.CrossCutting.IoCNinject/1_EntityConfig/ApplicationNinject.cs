using Ninject.Modules;
using XRM.Application._0_Interface._00_Sistema;
using XRM.Application._0_Interface._01_Cadastro;
using XRM.Application._0_Interface._99_Global;
using XRM.Application._1_Service._10_Sistema;
using XRM.Application._1_Service._11_Cadastro;
using XRM.Application._1_Service._99_Global;

namespace XRM.Infra.CrossCutting.IoCNinject._1_EntityConfig
{
    public class ApplicationNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));

            #region Sistema

            Bind<iasSISDEPARTA>().To<asvSISDEPARTA>();
            Bind<iasSISEMPRESA>().To<asvSISEMPRESA>();
            Bind<iasSISMODULOX>().To<asvSISMODULOX>();
            Bind<iasSISTEMAXXX>().To<asvSISTEMAXXX>();

            #endregion Sistema

            #region Cadastro

            Bind<iasCADEMAILXX>().To<asvCADEMAILXX>();
            Bind<iasCADENDEREC>().To<asvCADENDEREC>();
            Bind<iasCADTELEFON>().To<asvCADTELEFON>();

            #endregion Cadastro
        }
    }
}
