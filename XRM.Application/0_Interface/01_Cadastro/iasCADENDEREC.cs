using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._21_Cadastro;

namespace XRM.Application._0_Interface._01_Cadastro
{
    // ias = Interface App Service
    public interface iasCADENDEREC : IDisposable
    {
        void Add(vmdCADENDEREC customerViewModel);
        IEnumerable<vmdCADENDEREC> GetAll();
        vmdCADENDEREC GetById(int id);
        void Update(vmdCADENDEREC customerViewModel);
        void Remove(int id);
        void Remove(vmdCADENDEREC id);
    }
}
