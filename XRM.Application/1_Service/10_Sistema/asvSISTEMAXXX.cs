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
    public class asvSISTEMAXXX : iasSISTEMAXXX
    {
        private readonly disSISTEMAXXX _disSISTEMAXXX;
        private readonly IMapper _mapper;

        public asvSISTEMAXXX(disSISTEMAXXX objSISTEMAXXX)
        {
            _disSISTEMAXXX = objSISTEMAXXX;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdSISTEMAXXX> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdSISTEMAXXX>>(_disSISTEMAXXX.GetAll());
        }

        public vmdSISTEMAXXX GetById(int id)
        {
            return _mapper.Map<vmdSISTEMAXXX>(_disSISTEMAXXX.GetById(id));
        }

        public void Add(vmdSISTEMAXXX customerViewModel)
        {
            var categoria = _mapper.Map<TBSISTEMAXXX>(customerViewModel);
            _disSISTEMAXXX.Add(categoria);
        }

        public void Update(vmdSISTEMAXXX customerViewModel)
        {
            var categoria = _mapper.Map<TBSISTEMAXXX>(customerViewModel);
            _disSISTEMAXXX.Update(categoria);
        }

        public void Remove(vmdSISTEMAXXX customerViewModel)
        {
            var categoria = _mapper.Map<TBSISTEMAXXX>(customerViewModel);
            _disSISTEMAXXX.Remove(categoria);
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
