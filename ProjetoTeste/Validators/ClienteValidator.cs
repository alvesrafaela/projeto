using ProjetoTeste.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjetoTeste.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(b => b.Nome).NotEmpty().WithMessage("Nome obrigatório.");
            RuleFor(b => b.Nome).Length(1,30).WithMessage("Nome inválido.");
            RuleFor(b => b.CPF).NotEmpty().WithMessage("CPF obrigatório.");
            RuleFor(b => IsCPF(b.CPF)).Equal(true).WithMessage("CPF inválido.");
            RuleFor(b => b.DataNascimento).NotEmpty().WithMessage("Data de Nascimento obrigatória."); 
        }

        private static bool IsCPF(string cpf)
        {
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            return true;
        }

    }
}
