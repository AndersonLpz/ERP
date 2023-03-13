using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._21_Cadastro;

namespace XRM.Application._0_Interface._01_Cadastro
{
    // ias = Interface App Service
    public interface iasCADTELEFON : IDisposable
    {
        void Add(vmdCADTELEFON customerViewModel);
        IEnumerable<vmdCADTELEFON> GetAll();
        vmdCADTELEFON GetById(int id);
        void Update(vmdCADTELEFON customerViewModel);
        void Remove(int id);
        void Remove(vmdCADTELEFON id);
    }
}