using ProjetoTeste.Domain.Models;
using ProjetoTeste.Domain.Repositories;
using ProjetoTeste.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public Task<Endereco> Editar(int idEndereco, Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int idEndereco)
        {
            await _repository.Excluir(idEndereco);
        }

        public async Task<IEnumerable<Endereco>> Listar()
        {
            return await _repository.Listar();
        }

        public async Task<Endereco> Obter(int idEndereco)
        {
            return await _repository.Obter(idEndereco);
        }

        public Task<Endereco> Salvar(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
