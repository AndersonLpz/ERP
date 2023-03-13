using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Infra.Data._1_EntityConfig._11_Cadastro
{
    public class decCADEMAILXX : EntityTypeConfiguration<TBCADEMAILXX>
    {
        public decCADEMAILXX()
        {
            HasKey(x => x.TBCADEMAILXX_NS);

            Property(x => x.TBCADEMAILXX_NM).IsRequired();

            Property(x => x.TBCADEMAILXX_DS).IsOptional();

            Property(x => x.TBCADEMAILXX_PREF).IsOptional();

            Property(x => x.TBCADEMAILXX_DT_CAD).IsRequired();

            Property(x => x.TBCADEMAILXX_DT_INA).IsOptional();

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
