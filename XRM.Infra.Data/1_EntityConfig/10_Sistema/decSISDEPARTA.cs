using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    public class decSISDEPARTA : EntityTypeConfiguration<TBSISDEPARTA>
    {
        public decSISDEPARTA()
        {
            HasKey(x => x.TBSISDEPARTA_NS);

            Property(x => x.TBSISDEPARTA_NM).IsRequired();

            Property(x => x.TBSISDEPARTA_DS).IsOptional();

            Property(x => x.TBSISDEPARTA_DT_CAD).IsRequired();

            Property(x => x.TBSISDEPARTA_DT_INA).IsOptional();

            /*******************************************************************************/
            HasOptional(x => x.TBSISEMPRESA).WithMany().HasForeignKey(x => x.TBSISEMPRESA_NS);
        }
    }
}
