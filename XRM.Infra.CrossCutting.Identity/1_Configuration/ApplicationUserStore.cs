using Microsoft.AspNet.Identity.EntityFramework;
using XRM.Infra.CrossCutting.Identity._0_Context;
using XRM.Infra.CrossCutting.Identity._2_Model;

namespace XRM.Infra.CrossCutting.Identity._1_Configuration
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}