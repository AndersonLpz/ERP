using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._10_Repositories._100_Sistema;
using XRM.Domain._1_Interfaces._11_Services._110_Sistema;
using XRM.Domain._2_Services._99_Global;

namespace XRM.Domain._2_Services._20_Sistema
{
    // dsv = Domain Service
    public class dsvSISDEPARTA : ServiceBase<TBSISDEPARTA>, disSISDEPARTA
    {
        private readonly dirSISDEPARTA _dirSISDEPARTA;

        public dsvSISDEPARTA(dirSISDEPARTA objSISDEPARTA)
            : base(objSISDEPARTA)
        {
            _dirSISDEPARTA = objSISDEPARTA;
        }
    }
}
