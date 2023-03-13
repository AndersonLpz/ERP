using System.Collections.Generic;
using System.Linq;
using XRM.Domain._0_Entities._01_Cadastro;
using XRM.Domain._1_Interfaces._10_Repositories._101_Cadastro;
using XRM.Infra.Data._2_Repositories._99_Geral;

namespace XRM.Infra.Data._2_Repositories._21_Cadastro
{
    // idr = Infra Data Repositories
    public class idrCADENDEREC : RepositoryBase<TBCADENDEREC>, dirCADENDEREC
    {
        public IEnumerable<TBCADENDEREC> BuscarPorNome(string strTBCADENDEREC_NM)
        {
            return Db.TBCADENDEREC.Where(p => p.TBCADENDEREC_NM == strTBCADENDEREC_NM);
        }
    }
}
