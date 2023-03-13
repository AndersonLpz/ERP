using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    public class decAspNetUserLogins : EntityTypeConfiguration<TBAspNetUserLogins>
    {
        public decAspNetUserLogins()
        {
            ToTable("AspNetUserLogins");

            HasKey(u => u.LoginProvider);

            Property(u => u.LoginProvider).IsRequired().HasMaxLength(128);

            HasKey(u => u.ProviderKey);

            Property(u => u.ProviderKey).IsRequired().HasMaxLength(128);

            HasKey(u => u.UserId);

            Property(u => u.UserId).IsRequired().HasMaxLength(128);
        }
    }
}
