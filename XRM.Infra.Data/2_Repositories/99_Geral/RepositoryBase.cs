using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using XRM.Domain._1_Interfaces._10_Repositories._999_Geral;
using XRM.Infra.Data._0_Context;

namespace XRM.Infra.Data._2_Repositories._99_Geral
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        protected XRMContext Db = new XRMContext();
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

       /* public TEntity GetById1()
        {
            return Db.Set<TEntity>().Select(s => s.);
        }*/

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }



        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
