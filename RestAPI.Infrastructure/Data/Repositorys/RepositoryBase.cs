
using RestAPI.Domain.Core.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RestAPI.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Remove(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();

        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
