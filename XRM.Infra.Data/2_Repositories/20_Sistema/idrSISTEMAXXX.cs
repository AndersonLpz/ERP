using System.Collections.Generic;
using System.Linq;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._10_Repositories._100_Sistema;
using XRM.Infra.Data._2_Repositories._99_Geral;

namespace XRM.Infra.Data._2_Repositories._20_Sistema
{
    // idr = Infra Data Repositories
    public class idrSISTEMAXXX : RepositoryBase<TBSISTEMAXXX>, dirSISTEMAXXX
    {
        public IEnumerable<TBSISTEMAXXX> BuscarPorNome(string strTBSISTEMAXXX_NM)
        {
            return Db.TBSISTEMAXXX.Where(p => p.TBSISTEMAXXX_NM == strTBSISTEMAXXX_NM);
        }
    }
}
