using XRM.Domain._0_Entities._01_Cadastro;
using XRM.Domain._1_Interfaces._10_Repositories._101_Cadastro;
using XRM.Domain._1_Interfaces._11_Services._111_Cadastro;
using XRM.Domain._2_Services._99_Global;

namespace XRM.Domain._2_Services._21_Cadastro
{
    // dsv = Domain Service
    public class dsvCADEMAILXX : ServiceBase<TBCADEMAILXX>, disCADEMAILXX
    {
        private readonly dirCADEMAILXX _dirCADEMAILXX;

        public dsvCADEMAILXX(dirCADEMAILXX objCADEMAILXX)
            : base(objCADEMAILXX)
        {
            _dirCADEMAILXX = objCADEMAILXX;
        }
    }
}
