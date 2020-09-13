using Autofac;
using RestAPI.Application;
using RestAPI.Application.Interfaces;
using RestAPI.Domain.Core.Interfaces.Repositorys;
using RestAPI.Domain.Core.Interfaces.Services;
using RestAPI.Infrastructure.Data.Repositorys;
using RestAPI.Domain.Services;
using RestAPI.Application.Mappers;
using RestAPI.Application.Interfaces.Mappers;

namespace RestAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        //Injeção de dependência
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion


        }
    }
}
