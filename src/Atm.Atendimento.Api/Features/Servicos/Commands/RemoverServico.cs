using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Servicos.Commands
{
    public class RemoverServicoCommand : IRequest<RemoverServicoCommandResponse>
    {
        public Guid Id { get; set; }
    }

    public class RemoverServicoCommandResponse
    {

    }

    public class RemoverServicoCommandHandler : IRequestHandler<RemoverServicoCommand, RemoverServicoCommandResponse>
    {
        public Task<RemoverServicoCommandResponse> Handle(RemoverServicoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    public class RemoverServicoCommandValidator : AbstractValidator<RemoverServicoCommand>
    {
        public RemoverServicoCommandValidator()
        {
        }
    }
}
