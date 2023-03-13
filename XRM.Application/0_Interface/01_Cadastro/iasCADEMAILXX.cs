using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._21_Cadastro;

namespace XRM.Application._0_Interface._01_Cadastro
{
    // ias = Interface App Service
    public interface iasCADEMAILXX : IDisposable
    {
        void Add(vmdCADEMAILXX customerViewModel);
        IEnumerable<vmdCADEMAILXX> GetAll();
        vmdCADEMAILXX GetById(int id);
        void Update(vmdCADEMAILXX customerViewModel);
        void Remove(int id);
        void Remove(vmdCADEMAILXX id);
    }
}
