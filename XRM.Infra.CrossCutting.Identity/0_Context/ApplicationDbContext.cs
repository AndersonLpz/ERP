using Microsoft.AspNet.Identity.EntityFramework;
using System;
using XRM.Infra.CrossCutting.Identity._2_Model;

namespace XRM.Infra.CrossCutting.Identity._0_Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("XtremeDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}