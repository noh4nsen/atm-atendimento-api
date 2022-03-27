using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Orçamentos.Commands.AgendamentoFeature
{
    public class AgendarAtendimentoCommand : IRequest<AgendarAtendimentoCommandResponse>
    {
    }

    public class AgendarAtendimentoCommandResponse
    {

    }

    public class AgendarAtendimentoCommandHandler : IRequestHandler<AgendarAtendimentoCommand, AgendarAtendimentoCommandResponse>
    {
        public Task<AgendarAtendimentoCommandResponse> Handle(AgendarAtendimentoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    public class AgendarAtendimentoCommandValidator : AbstractValidator<AgendarAtendimentoCommand>
    {
        public AgendarAtendimentoCommandValidator()
        {
        }
    }
}
