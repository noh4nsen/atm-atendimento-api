using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Orçamentos.Commands.RemoverOrcamentoFeature
{
    public class RemoverOrcamentoCommandHandler : IRequestHandler<RemoverOrcamentoCommand, RemoverOrcamentoCommandResponse>
    {
        public Task<RemoverOrcamentoCommandResponse> Handle(RemoverOrcamentoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
