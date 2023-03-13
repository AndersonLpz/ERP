namespace XRM.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using XRM.Infra.Data._0_Context;
    using XRM.Infra.Data.Migrations._0_Sistema;
    using XRM.Infra.Data.Migrations._1_Cadastro;

    internal sealed class Configuration : DbMigrationsConfiguration<XRMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(XRMContext context)
        {

            #region 0_Sistema

            mgtSISMODULOX.AddOrUpdate(context);
            mgtSISTEMAXXX.AddOrUpdate(context);

            #endregion 0_Sistema

            #region 1_Cadastro

            mgtCADTELEFTP.AddOrUpdate(context);

            #endregion 1_Cadastro
        }
    }
}
