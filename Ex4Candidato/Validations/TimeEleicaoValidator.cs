using Ex4Candidato.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4Candidato.Validations
{
    public class TimeEleicaoValidator : AbstractValidator<TimeEleicao>
    {
        public TimeEleicaoValidator()
        {
            RuleFor(p => p.nomeCandidato).NotEmpty().WithMessage("Nome do candidato é Obrigatário !")
                                         .NotNull().WithMessage("Nome do candidato é obrigatório")
                                         .MinimumLength(3).WithMessage("Nome pode ter no mínino 3 caracteres")
                                         .MaximumLength(20).WithMessage("Nome pode ter no máximo 20 caracteres");
            RuleFor(p => p.partido).NotEmpty().WithMessage("Digite o Partido !");
            RuleFor(p => p.id).NotEmpty().WithMessage("Digite o id candidato !");
            RuleFor(p => p.foto).NotEmpty().WithMessage("Adicione a foto do candidato !");
            RuleFor(p => p.numero).NotEmpty().WithMessage("Digite o númeo do Partido !");

        }
        
    }
}
