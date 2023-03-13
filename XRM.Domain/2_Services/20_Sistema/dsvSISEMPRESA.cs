using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._10_Repositories._100_Sistema;
using XRM.Domain._1_Interfaces._11_Services._110_Sistema;
using XRM.Domain._2_Services._99_Global;

namespace XRM.Domain._2_Services._20_Sistema
{
    // dsv = Domain Service
    public class dsvSISEMPRESA : ServiceBase<TBSISEMPRESA>, disSISEMPRESA 
    {
        private readonly dirSISEMPRESA  _dirSISEMPRESA ;

        public dsvSISEMPRESA (dirSISEMPRESA  objSISEMPRESA )
            : base(objSISEMPRESA )
        {
            _dirSISEMPRESA  = objSISEMPRESA ;
        }
    }
}
