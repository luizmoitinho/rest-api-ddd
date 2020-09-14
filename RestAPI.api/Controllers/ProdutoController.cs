using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Application.Dtos;
using RestAPI.Application.Interfaces;

namespace RestAPI.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicatonServiceProduto;

       public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
       {
           _applicatonServiceProduto = applicationServiceProduto;

       }

       //GET api/values
       [HttpGet]
       public ActionResult<IEnumerable<string>> Get()
       {
          return Ok(_applicatonServiceProduto.GetAll());
       }

        //GET api/values/S
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicatonServiceProduto.GetById(id));
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]ProdutoDto produtoDto)
        {

            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicatonServiceProduto.Add(produtoDto);
                return Ok("Cliente Cadastro com sucesso!");

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //PUT api/values/S
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicatonServiceProduto.Update(produtoDto);
                return Ok("Produto atualizado com sucesso!");

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //Delete api/values/S
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _applicatonServiceProduto.Remove(produtoDto);
                return Ok("Produto removido com sucesso!");

            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}