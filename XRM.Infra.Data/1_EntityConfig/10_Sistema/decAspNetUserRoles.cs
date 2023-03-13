using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    public class decAspNetUserRoles : EntityTypeConfiguration<TBAspNetUserRoles>
    {
        public decAspNetUserRoles()
        {
            ToTable("AspNetUserRoles");

            HasKey(u => u.UserId);

            Property(u => u.UserId).IsRequired().HasMaxLength(128);

            HasKey(u => u.RoleId);

            Property(u => u.RoleId).IsRequired().HasMaxLength(128);

        }
    }
}
