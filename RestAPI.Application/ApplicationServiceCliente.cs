using RestAPI.Application.Dtos;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Interfaces.Mappers;
using RestAPI.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RestAPI.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;
        
        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Add(cliente);

        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClientesDto(clientes);

        }

        public ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDto(cliente);

        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.remove(cliente);

        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
            serviceCliente.Update(cliente);

        }
    }
}
