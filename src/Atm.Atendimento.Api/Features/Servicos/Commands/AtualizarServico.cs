using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Servicos.Commands
{
    public class AtualizarServicoCommand : IRequest<AtualizarServicoCommandResponse>
    {
    }

    public class AtualizarServicoCommandResponse
    {

    }

    public class AtualizarServicoCommandHandler : IRequestHandler<AtualizarServicoCommand, AtualizarServicoCommandResponse>
    {
        public Task<AtualizarServicoCommandResponse> Handle(AtualizarServicoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    public class AtualizarServicoCommandValidator : AbstractValidator<AtualizarServicoCommand>
    {
        public AtualizarServicoCommandValidator()
        {
        }
    }
}
