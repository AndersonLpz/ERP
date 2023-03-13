using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Infra.Data._1_EntityConfig._11_Cadastro
{
    public class decCADENDEREC : EntityTypeConfiguration<TBCADENDEREC>
    {
        public decCADENDEREC()
        {
            HasKey(x => x.TBCADENDEREC_NS);

            Property(x => x.TBCADENDEREC_NM).IsRequired();

            Property(x => x.TBCADENDEREC_DS).IsOptional();

            Property(x => x.TBCADENDEREC_NU).IsOptional();

            Property(x => x.TBCADENDEREC_COMPLEMENTO).IsOptional().HasMaxLength(250);

            Property(x => x.TBCADENDEREC_CEP).IsOptional();

            Property(x => x.TBCADENDEREC_CIDADE).IsOptional().HasMaxLength(250);

            Property(x => x.TBCADENDEREC_UF).IsOptional().HasMaxLength(2);

            Property(x => x.TBCADENDEREC_PREF).IsOptional();

            Property(x => x.TBCADENDEREC_DT_CAD).IsRequired();

            Property(x => x.TBCADENDEREC_DT_INA).IsOptional();

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
