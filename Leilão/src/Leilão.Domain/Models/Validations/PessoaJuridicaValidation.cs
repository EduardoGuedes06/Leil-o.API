using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Domain.Models.Validations
{
    public class PessoaJuridicaValidation : AbstractValidator<PessoaJuridica>
    {
        public PessoaJuridicaValidation()
        {
            RuleFor(c => c.CNPJ)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
