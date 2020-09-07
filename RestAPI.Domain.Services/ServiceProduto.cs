using ApiRest.Domain.Entitys;
using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;

namespace RestAPI.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
