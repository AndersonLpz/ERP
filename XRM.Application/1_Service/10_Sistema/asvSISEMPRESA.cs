using AutoMapper;
using System.Collections.Generic;
using XRM.Application._0_Interface._00_Sistema;
using XRM.Application._2_ViewModels._20_Sistema;
using XRM.Application._3_AutoMapper;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._1_Interfaces._11_Services._110_Sistema;

namespace XRM.Application._1_Service._10_Sistema
{
    // asv = App Service Base
    public class asvSISEMPRESA : iasSISEMPRESA
    {
        private readonly disSISEMPRESA _disSISEMPRESA;
        private readonly IMapper _mapper;

        public asvSISEMPRESA(disSISEMPRESA objSISEMPRESA)
        {
            _disSISEMPRESA = objSISEMPRESA;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdSISEMPRESA> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdSISEMPRESA>>(_disSISEMPRESA.GetAll());
        }

        public vmdSISEMPRESA GetById(int id)
        {
            return _mapper.Map<vmdSISEMPRESA>(_disSISEMPRESA.GetById(id));
        }

        public void Add(vmdSISEMPRESA customerViewModel)
        {
            var categoria = _mapper.Map<TBSISEMPRESA>(customerViewModel);
            _disSISEMPRESA.Add(categoria);
        }

        public void Update(vmdSISEMPRESA customerViewModel)
        {
            var categoria = _mapper.Map<TBSISEMPRESA>(customerViewModel);
            _disSISEMPRESA.Update(categoria);
        }

        public void Remove(vmdSISEMPRESA customerViewModel)
        {
            var categoria = _mapper.Map<TBSISEMPRESA>(customerViewModel);
            _disSISEMPRESA.Remove(categoria);
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
