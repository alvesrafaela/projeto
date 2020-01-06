using System;
using System.Threading.Tasks;
using ProjetoTeste.Domain.Models;
using ProjetoTeste.Domain.Repositories;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ClienteRepository
{
    private readonly IDbConnection dbCon;

    public ClienteRepository(IDbConnection dbCon)
    {
        this.dbCon = dbCon;
    }

    public async Task<Cliente> Editar(Cliente cliente)
    {
        throw new NotImplementedException();

    }

    public async Task Excluir(int numero)
    {

        throw new NotImplementedException();

    }

    public Task<IEnumerable<Cliente>> Listar()
    {
        throw new NotImplementedException();
    }

    public Task<Cliente> Obter(int numero)
    {
        throw new NotImplementedException();
    }

    public Task<Cliente> ObterClienteCPF(string numCpf)
    {
        string query = "SELECT * " +
                   "FROM Cliente " +
                   "WHERE CPF = @CPF ";

        throw new NotImplementedException();
    }

    public Task<Cliente> Salvar(Cliente cliente)
    {
        throw new NotImplementedException();
    }
}

