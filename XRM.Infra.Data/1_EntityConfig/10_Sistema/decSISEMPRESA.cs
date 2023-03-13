using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    // dec = Data Entity Config

    public class decSISEMPRESA : EntityTypeConfiguration<TBSISEMPRESA>
    {
        public decSISEMPRESA()
        {
            HasKey(x => x.TBSISEMPRESA_NS);

            Property(x => x.TBSISEMPRESA_NM).IsRequired();

            Property(x => x.TBSISEMPRESA_NM_FANTASIA).IsOptional();

            Property(x => x.TBSISEMPRESA_DS).IsOptional();

            Property(x => x.TBSISEMPRESA_DT_CAD).IsRequired();

            Property(x => x.TBSISEMPRESA_DT_INA).IsOptional();

            Property(x => x.TBSISEMPRESA_CPF_CNPJ).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));

        }
    }
}
