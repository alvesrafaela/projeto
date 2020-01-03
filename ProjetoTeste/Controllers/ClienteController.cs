using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoTeste.Domain.Models;
using ProjetoTeste.Domain.Services;

namespace ProjetoTeste.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService service)
        {
            _clienteService = service;
        }

        [HttpGet()]
        public async Task<IEnumerable<Cliente>> ListarCliente()
        {
            var clientes = await _clienteService.Listar();
            return clientes;
        }

        [HttpGet("{idCliente}")]
        public async Task<ActionResult<Cliente>> Obter(int idCliente)
        {
            var cliente = await _clienteService.Obter(idCliente);

            if (cliente == null)
                return NotFound(new { Message = "Cliente não encontrado" });

            return Ok(cliente);
        }

        [HttpDelete("{idCliente}")]
        public async Task<IActionResult> Excluir(int idCliente)
        {
            await _clienteService.Excluir(idCliente);
            return Ok();
        }
    }
}
