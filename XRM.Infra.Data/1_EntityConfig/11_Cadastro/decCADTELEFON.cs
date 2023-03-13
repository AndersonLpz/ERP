using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Infra.Data._1_EntityConfig._11_Cadastro
{
    public class decCADTELEFON : EntityTypeConfiguration<TBCADTELEFON>
    {
        public decCADTELEFON()
        {
            HasKey(x => x.TBCADTELEFON_NS);

            Property(x => x.TBCADTELEFON_DDD).IsOptional();

            Property(x => x.TBCADTELEFON_NUM).IsRequired();

            Property(x => x.TBCADTELEFON_PREF).IsOptional();

            Property(x => x.TBCADTELEFON_DT_CAD).IsRequired();

            Property(x => x.TBCADTELEFON_DT_INA).IsOptional();

            HasRequired(x => x.TBCADTELEFTP).WithMany().HasForeignKey(x => x.TBCADTELEFTP_NS);

            /*
             * TBSISUSUARIO
             */
            HasOptional(x => x.TBSISUSUARIO).WithMany().HasForeignKey(x => x.TBSISUSUARIO_NS);

            /*
             * TBCADCLIENTE
             */
            HasOptional(x => x.TBCADCLIENTE).WithMany().HasForeignKey(x => x.TBCLIENTEXXX_NS);

            /*
             * TBSISEMPRESA
             */
            HasOptional(x => x.TBSISEMPRESA).WithMany().HasForeignKey(x => x.TBSISEMPRESA_NS);
        }
    }
}
