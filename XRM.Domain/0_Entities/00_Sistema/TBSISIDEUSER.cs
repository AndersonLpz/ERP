using System;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
    * Tabela de manipulação do login do AspNet Identity
    */
    public class TBSISIDEUSER
    {
        public TBSISIDEUSER()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public virtual string Email { get; set; }

        public virtual bool EmailConfirmed { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string SecurityStamp { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual bool PhoneNumberConfirmed { get; set; }

        public virtual bool TwoFactorEnabled { get; set; }

        public virtual DateTime? LockoutEndDateUtc { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public virtual int AccessFailedCount { get; set; }

        public virtual string UserName { get; set; }

        public string StrRetornaID(TBSISIDEUSER TBSISIDEUSER)
        {
            return TBSISIDEUSER.Id;
        }
    }
}