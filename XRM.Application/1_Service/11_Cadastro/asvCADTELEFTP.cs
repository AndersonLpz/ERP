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
    public class asvCADTELEFTP : iasCADTELEFTP
    {
        private readonly disCADTELEFTP _disCADTELEFTP;
        private readonly IMapper _mapper;

        public asvCADTELEFTP(disCADTELEFTP objCADTELEFTP)
        {
            _disCADTELEFTP = objCADTELEFTP;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdCADTELEFTP> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdCADTELEFTP>>(_disCADTELEFTP.GetAll());
        }

        public vmdCADTELEFTP GetById(int id)
        {
            return _mapper.Map<vmdCADTELEFTP>(_disCADTELEFTP.GetById(id));
        }

        public void Add(vmdCADTELEFTP customerViewModel)
        {
            var categoria = _mapper.Map<TBCADTELEFTP>(customerViewModel);
            _disCADTELEFTP.Add(categoria);
        }

        public void Update(vmdCADTELEFTP customerViewModel)
        {
            var categoria = _mapper.Map<TBCADTELEFTP>(customerViewModel);
            _disCADTELEFTP.Update(categoria);
        }

        public void Remove(vmdCADTELEFTP customerViewModel)
        {
            var categoria = _mapper.Map<TBCADTELEFTP>(customerViewModel);
            _disCADTELEFTP.Remove(categoria);
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

