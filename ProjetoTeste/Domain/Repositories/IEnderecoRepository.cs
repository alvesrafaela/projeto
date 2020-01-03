using ProjetoTeste.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Domain.Repositories
{
    public interface IEnderecoRepository
    {
        Task<Endereco> Obter(int numero);
        Task<IEnumerable<Endereco>> Listar();
        Task<Endereco> Salvar(Endereco endereco);
        Task<Endereco> Editar(Endereco endereco);
        Task Excluir(int idEndereco);
    }
}
