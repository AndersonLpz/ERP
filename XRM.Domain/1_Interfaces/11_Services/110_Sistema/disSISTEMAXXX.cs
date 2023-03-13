using System.Collections.Generic;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._11_Services._999_Global;

namespace XRM.Domain._1_Interfaces._11_Services._110_Sistema
{
    // dis = Domain Interfaces Services
    public interface disSISTEMAXXX : IServiceBase<TBSISTEMAXXX>
    {
        IEnumerable<TBSISTEMAXXX> BuscarPorNome(string TBSYSCADASTR_NM);
    }
}
