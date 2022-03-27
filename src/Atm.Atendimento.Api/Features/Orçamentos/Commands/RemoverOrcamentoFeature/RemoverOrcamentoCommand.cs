using FluentValidation;
using MediatR;

namespace Atm.Atendimento.Api.Features.Orçamentos.Commands.RemoverOrcamentoFeature
{
    public class RemoverOrcamentoCommand : IRequest<RemoverOrcamentoCommandResponse>
    {
    }

    public class RemoverOrcamentoCommandValidator : AbstractValidator<RemoverOrcamentoCommand>
    {
        public RemoverOrcamentoCommandValidator()
        {
        }
    }
}
