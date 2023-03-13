using System;

namespace XRM.Domain._0_Entities._00_Sistema
{
    public class TBAspNetRoles
    {
        public TBAspNetRoles()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public virtual string Name { get; set; }
    }
}
