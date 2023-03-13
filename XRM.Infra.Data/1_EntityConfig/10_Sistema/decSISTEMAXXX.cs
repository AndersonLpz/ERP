using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    // dec = Data Entity Config

    public class decSISTEMAXXX : EntityTypeConfiguration<TBSISTEMAXXX>
    {
        public decSISTEMAXXX()
        {
            {
                HasKey(c => c.TBSISTEMAXXX_NS);

                Property(c => c.TBSISTEMAXXX_NM).IsRequired();

                Property(c => c.TBSISTEMAXXX_DS).IsOptional();

                Property(c => c.TBSISTEMAXXX_DT_INA).IsOptional();

                Property(c => c.TBSISTEMAXXX_CONTROLLER).IsRequired().HasMaxLength(13);

                Property(c => c.TBSISTEMAXXX_VIEW).IsRequired().HasMaxLength(12);

                /************************************************************************/

                HasRequired(p => p.TBSISMODULOX).WithMany().HasForeignKey(p => p.TBSISMODULOX_NS);
            }
        }
    }
}
