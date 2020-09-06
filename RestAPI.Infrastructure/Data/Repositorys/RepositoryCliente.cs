using ApiRest.Domain.Entitys;
using RestAPI.Domain.Core.Interfaces.Repositorys;

namespace RestAPI.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;


        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;

        }

    }
}
