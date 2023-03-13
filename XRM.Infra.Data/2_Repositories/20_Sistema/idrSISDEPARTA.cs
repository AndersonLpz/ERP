using System.Collections.Generic;
using System.Linq;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._10_Repositories._100_Sistema;
using XRM.Infra.Data._2_Repositories._99_Geral;

namespace XRM.Infra.Data._2_Repositories._20_Sistema
{
    // idr = Infra Data Repositories
    public class idrSISDEPARTA : RepositoryBase<TBSISDEPARTA>, dirSISDEPARTA
    {
        public IEnumerable<TBSISDEPARTA> BuscarPorNome(string strTBSISDEPARTA_NM)
        {
            return Db.TBSISDEPARTA.Where(p => p.TBSISDEPARTA_NM == strTBSISDEPARTA_NM);
        }
    }
}
