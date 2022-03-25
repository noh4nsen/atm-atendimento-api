using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Servicos.Commands
{
    public class InserirServicoCommand : IRequest<InserirServicoCommandResponse>
    {
    }

    public class InserirServicoCommandResponse
    {

    }

    public class InserirServicoCommandHandler : IRequestHandler<InserirServicoCommand, InserirServicoCommandResponse>
    {
        public Task<InserirServicoCommandResponse> Handle(InserirServicoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    public class InserirServicoCommandValidator : AbstractValidator<InserirServicoCommand>
    {
        public InserirServicoCommandValidator()
        {
        }
    }
}
