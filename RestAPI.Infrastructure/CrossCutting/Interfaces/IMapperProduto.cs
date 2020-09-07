﻿using ApiRest.Domain.Entitys;
using RestAPI.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Infrastructure.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
