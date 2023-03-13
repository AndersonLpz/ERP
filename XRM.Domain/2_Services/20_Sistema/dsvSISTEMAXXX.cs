using System.Collections.Generic;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._10_Repositories._100_Sistema;
using XRM.Domain._1_Interfaces._11_Services._110_Sistema;
using XRM.Domain._2_Services._99_Global;

namespace XRM.Domain._2_Services._20_Sistema
{
    // dsv = Domain Service
    public class dsvSISTEMAXXX : ServiceBase<TBSISTEMAXXX>, disSISTEMAXXX
    {
        private readonly dirSISTEMAXXX _dirSISTEMAXXX;

        public dsvSISTEMAXXX(dirSISTEMAXXX objSISTEMAXXX)
            : base(objSISTEMAXXX)
        {
            _dirSISTEMAXXX = objSISTEMAXXX;
        }

        public IEnumerable<TBSISTEMAXXX> BuscarPorNome(string TBSISTEMAXXX_NM)
        {
            return _dirSISTEMAXXX.BuscarPorNome(TBSISTEMAXXX_NM);
        }
    }
}