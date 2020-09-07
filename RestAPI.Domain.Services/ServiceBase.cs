using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestAPI.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public TEntity GeById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}
