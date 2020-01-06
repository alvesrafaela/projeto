using ProjetoTeste.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> Obter(int numero);
        Task<IEnumerable<Cliente>> Listar();
        Task<Cliente> Salvar(Cliente cliente);
        Task<Cliente> Editar(Cliente cliente);
        Task Excluir(int idCliente);
        Task<Cliente> ObterClienteCPF(string numCpf);
    }
}
