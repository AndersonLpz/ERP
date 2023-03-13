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
    public class asvCADEMAILXX : iasCADEMAILXX
    {
        private readonly disCADEMAILXX _disCADEMAILXX;
        private readonly IMapper _mapper;

        public asvCADEMAILXX(disCADEMAILXX objCADEMAILXX)
        {
            _disCADEMAILXX = objCADEMAILXX;
            _mapper = AutoMapperConfig.Mapper;
        }

        public IEnumerable<vmdCADEMAILXX> GetAll()
        {
            return _mapper.Map<IEnumerable<vmdCADEMAILXX>>(_disCADEMAILXX.GetAll());
        }

        public vmdCADEMAILXX GetById(int id)
        {
            return _mapper.Map<vmdCADEMAILXX>(_disCADEMAILXX.GetById(id));
        }

        public void Add(vmdCADEMAILXX customerViewModel)
        {
            var categoria = _mapper.Map<TBCADEMAILXX>(customerViewModel);
            _disCADEMAILXX.Add(categoria);
        }

        public void Update(vmdCADEMAILXX customerViewModel)
        {
            var categoria = _mapper.Map<TBCADEMAILXX>(customerViewModel);
            _disCADEMAILXX.Update(categoria);
        }

        public void Remove(vmdCADEMAILXX customerViewModel)
        {
            var categoria = _mapper.Map<TBCADEMAILXX>(customerViewModel);
            _disCADEMAILXX.Remove(categoria);
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

