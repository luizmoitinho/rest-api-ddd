using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Core.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryaBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        void IRepositoryaBase<TEntity>.Add(TEntity obj)
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

        void IRepositoryaBase<TEntity>.Delete(TEntity obj)
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

        IEnumerable<TEntity> IRepositoryaBase<TEntity>.GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();

        }

        TEntity IRepositoryaBase<TEntity>.GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        void IRepositoryaBase<TEntity>.Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
