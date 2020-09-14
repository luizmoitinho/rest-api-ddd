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
    public class ClienteController : ControllerBase
    {

        private readonly IApplicationServiceCliente _applicatonServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicatonServiceCliente = applicationServiceCliente;

        }

        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicatonServiceCliente.GetAll());
        }

        //GET api/values/S
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicatonServiceCliente.GetById(id));
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]ClienteDto clienteDto) {

            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicatonServiceCliente.Add(clienteDto);
                return Ok("Cliente Cadastro com sucesso!");
                   
            }
            catch(Exception e) {
                throw e;
            }

        }

        //PUT api/values/S
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicatonServiceCliente.Update(clienteDto);
                return Ok("Cliente atualizado com sucesso!");

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        //Delete api/values/S
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _applicatonServiceCliente.Remove(clienteDto);
                return Ok("Cliente removido com sucesso!");

            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}