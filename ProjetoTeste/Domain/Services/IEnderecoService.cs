using ProjetoTeste.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Domain.Services
{
    public interface IEnderecoService
    {
        Task<Endereco> Obter(int idEndereco);
        Task<IEnumerable<Endereco>> Listar();
        Task<Endereco> Salvar(Endereco endereco);
        Task<Endereco> Editar(int idEndereco, Endereco endereco);
        Task Excluir(int idEndereco);
    }

}
