using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Infra.Data._1_EntityConfig._11_Cadastro
{
    public class decCADTELEFTP : EntityTypeConfiguration<TBCADTELEFTP>
    {
        public decCADTELEFTP()
        {
            HasKey(x => x.TBCADTELEFTP_NS);

            Property(x => x.TBCADTELEFTP_NM).IsRequired();

            Property(x => x.TBCADTELEFTP_DS).IsOptional();

            Property(x => x.TBCADTELEFTP_DT_CAD).IsRequired();

            Property(x => x.TBCADTELEFTP_DT_INA).IsOptional();
        }
    }
}
