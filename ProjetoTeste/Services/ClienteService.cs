using ProjetoTeste.Domain.Models;
using ProjetoTeste.Domain.Repositories;
using ProjetoTeste.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public Task<Cliente> Editar(int idCliente, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int idCliente)
        {
            await _repository.Excluir(idCliente);
        }

        public async Task<IEnumerable<Cliente>> Listar()
        {
            return await _repository.Listar();
        }

        public async Task<Cliente> Obter(int idCliente)
        {
            return await _repository.Obter(idCliente);
        }

        public Task<Cliente> Salvar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
