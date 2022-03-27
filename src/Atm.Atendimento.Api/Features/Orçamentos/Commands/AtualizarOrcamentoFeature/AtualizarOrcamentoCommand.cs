using FluentValidation;
using MediatR;

namespace Atm.Atendimento.Api.Features.Orçamentos.Commands.AtualizarOrcamentoFeature
{
    public class AtualizarOrcamentoCommand : IRequest<AtualizarOrcamentoCommandResponse>
    {
    }
    public class AtualizarOrcamentoCommandValidator : AbstractValidator<AtualizarOrcamentoCommand>
    {
        public AtualizarOrcamentoCommandValidator()
        {
        }
    }
}
