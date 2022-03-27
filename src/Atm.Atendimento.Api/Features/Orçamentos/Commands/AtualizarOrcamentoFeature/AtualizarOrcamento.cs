using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Orçamentos.Commands.AtualizarOrcamentoFeature
{
    public class AtualizarOrcamentoCommandHandler : IRequestHandler<AtualizarOrcamentoCommand, AtualizarOrcamentoCommandResponse>
    {
        public Task<AtualizarOrcamentoCommandResponse> Handle(AtualizarOrcamentoCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
