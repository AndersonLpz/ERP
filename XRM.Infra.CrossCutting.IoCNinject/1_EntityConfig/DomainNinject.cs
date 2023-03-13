using Ninject.Modules;
using XRM.Domain._1_Interfaces._11_Services._110_Sistema;
using XRM.Domain._1_Interfaces._11_Services._111_Cadastro;
using XRM.Domain._1_Interfaces._11_Services._999_Global;
using XRM.Domain._2_Services._20_Sistema;
using XRM.Domain._2_Services._21_Cadastro;
using XRM.Domain._2_Services._99_Global;

namespace XRM.Infra.CrossCutting.IoCNinject._1_EntityConfig
{
    public class DomainNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));

            #region Sistema

            Bind<disSISDEPARTA>().To<dsvSISDEPARTA>();
            Bind<disSISEMPRESA>().To<dsvSISEMPRESA>();
            Bind<disSISMODULOX>().To<dsvSISMODULOX>();
            Bind<disSISTEMAXXX>().To<dsvSISTEMAXXX>();

            #endregion Sistema

            #region Cadastro

            Bind<disCADEMAILXX>().To<dsvCADEMAILXX>();
            Bind<disCADENDEREC>().To<dsvCADENDEREC>();
            Bind<disCADTELEFON>().To<dsvCADTELEFON>();

            #endregion Cadastro
        }
    }
}
