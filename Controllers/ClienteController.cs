using cliente_service.Model;
using cliente_service.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cliente_service.Controllers
{
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        [Route("incluir")]
        public IActionResult Incluir([FromBody]ClienteModel clienteModel)
        {
            var cliente = _clienteService.Incluir(clienteModel);
            return CreatedAtRoute("GetCliente", new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}/alterar", Name = "UpdateCliente")]
        public IActionResult Alterar(int id, [FromBody] ClienteModel clienteModel)
        {
            var cliente = _clienteService.Alterar(id, clienteModel);
            return NoContent();
        }

        [HttpGet("{id}", Name = "GetCliente")]
        public IActionResult Get(int id)
        {
            var cliente = _clienteService.Consultar(id);

            if (cliente == null) return NotFound();

            return Ok(cliente);
        }
    }
}
