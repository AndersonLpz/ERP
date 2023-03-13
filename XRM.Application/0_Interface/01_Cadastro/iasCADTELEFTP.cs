using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRM.Application._2_ViewModels._21_Cadastro;

namespace XRM.Application._0_Interface._01_Cadastro
{
    // ias = Interface App Service
    public interface iasCADTELEFTP : IDisposable
    {
        void Add(vmdCADTELEFTP customerViewModel);
        IEnumerable<vmdCADTELEFTP> GetAll();
        vmdCADTELEFTP GetById(int id);
        void Update(vmdCADTELEFTP customerViewModel);
        void Remove(int id);
        void Remove(vmdCADTELEFTP id);
    }
}