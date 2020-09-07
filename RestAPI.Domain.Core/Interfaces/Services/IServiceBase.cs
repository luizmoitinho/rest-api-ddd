using System.Collections.Generic;

namespace RestAPI.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);

    }
}
