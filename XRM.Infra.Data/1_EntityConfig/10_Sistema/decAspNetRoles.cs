using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Infra.Data._1_EntityConfig._10_Sistema
{
    public class decAspNetRoles : EntityTypeConfiguration<TBAspNetRoles>
    {
        public decAspNetRoles()
        {
            ToTable("AspNetRoles");

            HasKey(u => u.Id);

            Property(u => u.Id).IsRequired().HasMaxLength(128);

            Property(u => u.Name).IsRequired().HasMaxLength(256).HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } })); ;
        }
    }
}
