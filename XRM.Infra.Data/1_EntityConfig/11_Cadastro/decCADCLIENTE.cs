using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Infra.Data._1_EntityConfig._11_Cadastro
{
    public class decCADCLIENTE : EntityTypeConfiguration<TBCADCLIENTE>
    {
        public decCADCLIENTE()
        {
            HasKey(x => x.TBCLIENTEXXX_NS);

            Property(x => x.TBCLIENTEXXX_NM).IsRequired();

            Property(x => x.TBCLIENTEXXX_DS).IsOptional();

            Property(x => x.TBCADCLIENTE_CPF_CNPJ).IsRequired();

            Property(x => x.TBCLIENTEXXX_DT_CAD).IsRequired();

            Property(x => x.TBCLIENTEXXX_DT_INA).IsOptional();

            Property(x => x.TBCLIENTEXXX_DT_ATU).IsRequired();
        }
    }
}
