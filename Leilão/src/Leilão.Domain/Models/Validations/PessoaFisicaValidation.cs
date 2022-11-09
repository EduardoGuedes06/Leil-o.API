using Business.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Domain.Models.Validations
{
    public class PessoaFisicaValidation : AbstractValidator<PessoaFisica>
    {
        public PessoaFisicaValidation()
        {
            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
