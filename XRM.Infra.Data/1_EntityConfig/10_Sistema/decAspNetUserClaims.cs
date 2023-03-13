using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    public class decAspNetUserClaims : EntityTypeConfiguration<TBAspNetUserClaims>
    {
        public decAspNetUserClaims()
        {
            ToTable("AspNetUserClaims");

            HasKey(u => u.Id);

            Property(u => u.Id).IsRequired();

            Property(u => u.UserId).IsRequired().HasMaxLength(128);

            Property(u => u.ClaimType).IsOptional();

            Property(u => u.ClaimValue).IsOptional();
        }
    }
}
