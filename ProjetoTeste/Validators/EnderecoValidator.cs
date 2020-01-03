using FluentValidation;
using ProjetoTeste.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Validators
{
    public class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(b => b.Logradouro).NotEmpty().WithMessage("Endereço obrigatório.")
                .Length(1,50).WithMessage("Endereço inválido.");
            
            RuleFor(b => b.Bairro).NotEmpty().WithMessage("Bairro obrigatório")
                .Length(1,40).WithMessage("Bairro inválido.");
            RuleFor(b => b.Cidade).NotEmpty().WithMessage("Cidade obrigatória.")
                .Length(1,40).WithMessage("Cidade inválida.");
            RuleFor(b => b.Estado).NotEmpty().WithMessage("Estado obrigatório.")
                .Length(1,40).WithMessage("Estado inválida.");
        }
    }
}
