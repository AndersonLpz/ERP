namespace XRM.Domain._0_Entities._00_Sistema
{
    public class TBAspNetUserClaims
    {
        public int Id { get; set; }

        public virtual string UserId { get; set; }

        public virtual string ClaimType { get; set; }

        public virtual string ClaimValue { get; set; }
    }
}
