using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._0_Entities._01_Cadastro;
using XRM.Infra.Data._1_EntityConfig._10_Sistema;
using XRM.Infra.Data._1_EntityConfig._11_Cadastro;

namespace XRM.Infra.Data._0_Context
{
    public class XRMContext : DbContext
    {

        public XRMContext() : base("DataBase") { }

        #region XRM.Domain

        #region 00_Sistema

        /****************************************************/
        /****************************************************/
        public DbSet<TBAspNetRoles> TBAspNetRoles { get; set; }
        public DbSet<TBAspNetUserClaims> TBAspNetUserClaims { get; set; }
        public DbSet<TBAspNetUserLogins> TBAspNetUserLogins { get; set; }
        public DbSet<TBAspNetUserRoles> TBAspNetUserRoles { get; set; }
        public DbSet<TBAspNetUsers> TBAspNetUsers { get; set; }
        /****************************************************/
        /****************************************************/
        public DbSet<TBSISDEPARTA> TBSISDEPARTA { get; set; }        
        public DbSet<TBSISEMPRESA> TBSISEMPRESA { get; set; }
        public DbSet<TBSISMODULOX> TBSISMODULOX { get; set; }
        public DbSet<TBSISTEMAXXX> TBSISTEMAXXX { get; set; }


        #endregion 00_Sistema

        #region 11_Cadastro

        public DbSet<TBCADCLIENTE> TBCADCLIENTE { get; set; }
        public DbSet<TBCADEMAILXX> TBCADEMAILXX { get; set; }
        public DbSet<TBCADENDEREC> TBCADENDEREC { get; set; }
        public DbSet<TBCADTELEFON> TBCADTELEFON { get; set; }
        public DbSet<TBCADTELEFTP> TBCADTELEFTP { get; set; }

        #endregion 11_Cadastro


        #endregion XRM.Domain
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ConfParamDbSet(modelBuilder);
            EntityConfigSistema(modelBuilder);
            EntityConfigCadastro(modelBuilder);
            
            base.OnModelCreating(modelBuilder);
        }

        protected static void ConfParamDbSet(DbModelBuilder modelBuilder)
        {
            #region Configurar DB Geral

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "_NS")
                .Configure(p => p.IsKey());

            /*modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "_CPF_CNPJ")
                .Configure(p => p.HasPrecision(14, 0));*/

            modelBuilder.Properties<Int64>()
                .Configure(p => p.HasColumnType("bigint"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Where(p => p.Name == p.ReflectedType.Name + "_NM")
                .Configure(p => p.HasMaxLength(150));

            modelBuilder.Properties<string>()
                .Where(p => p.Name == p.ReflectedType.Name + "_DS")
                .Configure(p => p.HasMaxLength(500));

            modelBuilder.Properties<string>()
                .Where(p => p.Name == p.ReflectedType.Name + "_SENHA")
                .Configure(p => p.HasMaxLength(20));

            modelBuilder.Properties<string>()
                .Where(p => p.Name == p.ReflectedType.Name + "_EMAIL")
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name == p.ReflectedType.Name + "_DT_CAD")
                .Configure(p => p.HasColumnType("DATE"));

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name == p.ReflectedType.Name + "_DT_INA")
                .Configure(p => p.HasColumnType("DATE"));

            #endregion
        }

        protected static void EntityConfigSistema(DbModelBuilder modelBuilder)
        {
            /****************************************************/
            /****************************************************/
            modelBuilder.Configurations.Add(new decAspNetRoles());
            modelBuilder.Configurations.Add(new decAspNetUserClaims());
            modelBuilder.Configurations.Add(new decAspNetUserLogins());
            modelBuilder.Configurations.Add(new decAspNetUserRoles());
            modelBuilder.Configurations.Add(new decAspNetUsers());
            /****************************************************/
            /****************************************************/
            modelBuilder.Configurations.Add(new decSISDEPARTA());
            modelBuilder.Configurations.Add(new decSISEMPRESA());
            modelBuilder.Configurations.Add(new decSISMODULOX());
            modelBuilder.Configurations.Add(new decSISTEMAXXX());
        }

        protected static void EntityConfigCadastro(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new decCADCLIENTE());
            modelBuilder.Configurations.Add(new decCADEMAILXX());
            modelBuilder.Configurations.Add(new decCADENDEREC());
            modelBuilder.Configurations.Add(new decCADTELEFON());
            modelBuilder.Configurations.Add(new decCADTELEFTP());
        }

        public override int SaveChanges()
        {

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(entry.Entity.ToString().Substring(entry.Entity.ToString().Length - 12) + "_DT_CAD") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(entry.Entity.ToString().Substring(entry.Entity.ToString().Length - 12) + "_DT_CAD").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property(entry.Entity.ToString().Substring(entry.Entity.ToString().Length - 12) + "_DT_CAD").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty(entry.Entity.ToString().Substring(entry.Entity.ToString().Length - 12) + "_DT_INA") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(entry.Entity.ToString().Substring(entry.Entity.ToString().Length - 12) + "_DT_INA").CurrentValue = (DateTime?)null;
                }

            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
