using AutoMapper;
using System.Collections.Generic;
using XRM.Application._0_Interface._01_Cadastro;
using XRM.Application._2_ViewModels._21_Cadastro;
using XRM.Application._3_AutoMapper;
using XRM.Domain._0_Entities._01_Cadastro;
using XRM.Domain._1_Interfaces._11_Services._111_Cadastro;

namespace XRM.Application._1_Service._11_Cadastro
{
    // asv = App Service Base
    public class asvCADTELEFON : iasCADTELEFON
    {
        private readonly disCADTELEFON _disCADTELEFON;
        private readonly IMapper _mapper;

        public asvCADTELEFON(disCADTELEFON objCADTELEFON)
        {
            _disCADTELEFON = objCADTELEFON;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdCADTELEFON> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdCADTELEFON>>(_disCADTELEFON.GetAll());
        }

        public vmdCADTELEFON GetById(int id)
        {
            return _mapper.Map<vmdCADTELEFON>(_disCADTELEFON.GetById(id));
        }

        public void Add(vmdCADTELEFON customerViewModel)
        {
            var categoria = _mapper.Map<TBCADTELEFON>(customerViewModel);
            _disCADTELEFON.Add(categoria);
        }

        public void Update(vmdCADTELEFON customerViewModel)
        {
            var categoria = _mapper.Map<TBCADTELEFON>(customerViewModel);
            _disCADTELEFON.Update(categoria);
        }

        public void Remove(vmdCADTELEFON customerViewModel)
        {
            var categoria = _mapper.Map<TBCADTELEFON>(customerViewModel);
            _disCADTELEFON.Remove(categoria);
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

