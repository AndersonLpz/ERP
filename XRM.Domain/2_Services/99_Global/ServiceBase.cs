using System;
using System.Collections.Generic;
using XRM.Domain._1_Interfaces._10_Repositories._999_Geral;
using XRM.Domain._1_Interfaces._11_Services._999_Global;

namespace XRM.Domain._2_Services._99_Global
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}