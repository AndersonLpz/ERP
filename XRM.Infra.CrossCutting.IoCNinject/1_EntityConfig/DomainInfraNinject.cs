using Ninject.Modules;
using XRM.Domain._1_Interfaces._10_Repositories._100_Sistema;
using XRM.Domain._1_Interfaces._10_Repositories._101_Cadastro;
using XRM.Domain._1_Interfaces._10_Repositories._999_Geral;
using XRM.Infra.Data._2_Repositories._20_Sistema;
using XRM.Infra.Data._2_Repositories._21_Cadastro;
using XRM.Infra.Data._2_Repositories._99_Geral;

namespace XRM.Infra.CrossCutting.IoCNinject._1_EntityConfig
{
    public class DomainInfraNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

            #region Sistema

            Bind<dirSISDEPARTA>().To<idrSISDEPARTA>();
            Bind<dirSISEMPRESA>().To<idrSISEMPRESA>();
            Bind<dirSISMODULOX>().To<idrSISMODULOX>();
            Bind<dirSISTEMAXXX>().To<idrSISTEMAXXX>();

            #endregion Sistema

            #region Cadastro

            Bind<dirCADEMAILXX>().To<idrCADEMAILXX>();
            Bind<dirCADENDEREC>().To<idrCADENDEREC>();
            Bind<dirCADTELEFON>().To<idrCADTELEFON>();

            #endregion Cadastro
        }
    }
}
