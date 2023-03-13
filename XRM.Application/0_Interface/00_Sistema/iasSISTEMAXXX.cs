using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.Application._0_Interface._00_Sistema
{
    // ias = Interface App Service
    public interface iasSISTEMAXXX : IDisposable
    {
        void Add(vmdSISTEMAXXX customerViewModel);
        IEnumerable<vmdSISTEMAXXX> GetAll();
        vmdSISTEMAXXX GetById(int id);
        void Update(vmdSISTEMAXXX customerViewModel);
        void Remove(int id);
        void Remove(vmdSISTEMAXXX id);
    }
}
