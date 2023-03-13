using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    public class decAspNetUsers : EntityTypeConfiguration<TBAspNetUsers>
    {
        public decAspNetUsers()
        {
            ToTable("AspNetUsers");

            HasKey(u => u.Id);

            Property(u => u.Id).IsRequired().HasMaxLength(128);

            Property(u => u.Email).IsRequired().HasMaxLength(256);

            Property(u => u.UserName).IsRequired().HasMaxLength(256);
        }
    }
}
