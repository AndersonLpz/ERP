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
    public class asvCADENDEREC : iasCADENDEREC
    {
        private readonly disCADENDEREC _disCADENDEREC;
        private readonly IMapper _mapper;

        public asvCADENDEREC(disCADENDEREC objCADENDEREC)
        {
            _disCADENDEREC = objCADENDEREC;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdCADENDEREC> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdCADENDEREC>>(_disCADENDEREC.GetAll());
        }

        public vmdCADENDEREC GetById(int id)
        {
            return _mapper.Map<vmdCADENDEREC>(_disCADENDEREC.GetById(id));
        }

        public void Add(vmdCADENDEREC customerViewModel)
        {
            var categoria = _mapper.Map<TBCADENDEREC>(customerViewModel);
            _disCADENDEREC.Add(categoria);
        }

        public void Update(vmdCADENDEREC customerViewModel)
        {
            var categoria = _mapper.Map<TBCADENDEREC>(customerViewModel);
            _disCADENDEREC.Update(categoria);
        }

        public void Remove(vmdCADENDEREC customerViewModel)
        {
            var categoria = _mapper.Map<TBCADENDEREC>(customerViewModel);
            _disCADENDEREC.Remove(categoria);
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

