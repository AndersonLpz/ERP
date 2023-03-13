using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.Application._0_Interface._00_Sistema
{
    // ias = Interface App Service
    public interface iasSISDEPARTA : IDisposable
    {
        void Add(vmdSISDEPARTA customerViewModel);
        IEnumerable<vmdSISDEPARTA> GetAll();
        vmdSISDEPARTA GetById(int id);
        void Update(vmdSISDEPARTA customerViewModel);
        void Remove(int id);
        void Remove(vmdSISDEPARTA id);
    }
}
