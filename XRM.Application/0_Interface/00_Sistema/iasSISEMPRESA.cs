using System;
using System.Collections.Generic;
using XRM.Application._2_ViewModels._20_Sistema;

namespace XRM.Application._0_Interface._00_Sistema
{
    // ias = Interface App Service
    public interface iasSISEMPRESA : IDisposable
    {
        void Add(vmdSISEMPRESA customerViewModel);
        IEnumerable<vmdSISEMPRESA> GetAll();
        vmdSISEMPRESA GetById(int id);
        void Update(vmdSISEMPRESA customerViewModel);
        void Remove(int id);
        void Remove(vmdSISEMPRESA id);
    }
}
