using Business.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilão.Domain.Models.Validations
{
    public class LeilaoValidation : AbstractValidator<Leilao>
    {
        public LeilaoValidation()
        {
            RuleFor(c => c.lanceMin)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.dataInicio)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(c => c.dataFim)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
