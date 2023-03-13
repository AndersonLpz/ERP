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
    public class asvSISDEPARTA : iasSISDEPARTA
    {
        private readonly disSISDEPARTA _disSISDEPARTA;
        private readonly IMapper _mapper;

        public asvSISDEPARTA(disSISDEPARTA objSISDEPARTA)
        {
            _disSISDEPARTA = objSISDEPARTA;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdSISDEPARTA> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdSISDEPARTA>>(_disSISDEPARTA.GetAll());
        }

        public vmdSISDEPARTA GetById(int id)
        {
            return _mapper.Map<vmdSISDEPARTA>(_disSISDEPARTA.GetById(id));
        }

        public void Add(vmdSISDEPARTA customerViewModel)
        {
            var categoria = _mapper.Map<TBSISDEPARTA>(customerViewModel);
            _disSISDEPARTA.Add(categoria);
        }

        public void Update(vmdSISDEPARTA customerViewModel)
        {
            var categoria = _mapper.Map<TBSISDEPARTA>(customerViewModel);
            _disSISDEPARTA.Update(categoria);
        }

        public void Remove(vmdSISDEPARTA customerViewModel)
        {
            var categoria = _mapper.Map<TBSISDEPARTA>(customerViewModel);
            _disSISDEPARTA.Remove(categoria);
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

    