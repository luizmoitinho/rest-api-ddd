﻿using ApiRest.Domain.Entitys;
using RestAPI.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);

    }
}
