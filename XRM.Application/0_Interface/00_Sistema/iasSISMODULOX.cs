using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.Application._0_Interface._00_Sistema
{
    // ias = Interface App Service
    public interface iasSISMODULOX : IDisposable
    {
        void Add(vmdSISMODULOX customerViewModel);
        IEnumerable<vmdSISMODULOX> GetAll();
        vmdSISMODULOX GetById(int id);
        void Update(vmdSISMODULOX customerViewModel);
        void Remove(int id);
        void Remove(vmdSISMODULOX id);
    }
}
