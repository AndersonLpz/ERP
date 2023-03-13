using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    // dec = Data Entity Config

    public class decSISMODULOX : EntityTypeConfiguration<TBSISMODULOX>
    {
        public decSISMODULOX()
        {
            {
                HasKey(x => x.TBSISMODULOX_NS);

                Property(x => x.TBSISMODULOX_NM).IsRequired();

                Property(x => x.TBSISMODULOX_DS).IsOptional();

                Property(x => x.TBSISMODULOX_DT_CAD).IsRequired();

                Property(x => x.TBSISMODULOX_DT_INA).IsOptional();
            }
        }
    }
}
