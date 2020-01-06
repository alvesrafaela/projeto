using ProjetoTeste.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Domain.Services
{
    public interface IClienteService
    {
        Task<Cliente> Obter(int idCliente);
        Task<IEnumerable<Cliente>> Listar();
        Task<Cliente> Salvar(Cliente cliente);
        Task<Cliente> Editar(int idCliente, Cliente cliente);
        Task Excluir(int idCliente);
        Task<Cliente> ObterClienteCPF(string numCpf);
    }
}
