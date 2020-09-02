using System.Collections.Generic;

namespace RestAPI.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryaBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);

    }
}
