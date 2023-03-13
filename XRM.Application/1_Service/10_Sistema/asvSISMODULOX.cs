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
    public class asvSISMODULOX : iasSISMODULOX
    {
        private readonly disSISMODULOX _disSISMODULOX;
        private readonly IMapper _mapper;

        public asvSISMODULOX(disSISMODULOX objSISMODULOX)
        {
            _disSISMODULOX = objSISMODULOX;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdSISMODULOX> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdSISMODULOX>>(_disSISMODULOX.GetAll());
        }

        public vmdSISMODULOX GetById(int id)
        {
            return _mapper.Map<vmdSISMODULOX>(_disSISMODULOX.GetById(id));
        }

        public void Add(vmdSISMODULOX customerViewModel)
        {
            var categoria = _mapper.Map<TBSISMODULOX>(customerViewModel);
            _disSISMODULOX.Add(categoria);
        }

        public void Update(vmdSISMODULOX customerViewModel)
        {
            var categoria = _mapper.Map<TBSISMODULOX>(customerViewModel);
            _disSISMODULOX.Update(categoria);
        }

        public void Remove(vmdSISMODULOX customerViewModel)
        {
            var categoria = _mapper.Map<TBSISMODULOX>(customerViewModel);
            _disSISMODULOX.Remove(categoria);
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
