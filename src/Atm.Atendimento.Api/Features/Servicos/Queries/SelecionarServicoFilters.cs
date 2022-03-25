using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Servicos.Queries
{
    public class SelecionarServicoFiltersQuery : IRequest<IEnumerable<SelecionarServicoByIdQueryResponse>>
    {
    }

    public class SelecionarServicoFiltersQueryHandler : IRequestHandler<SelecionarServicoFiltersQuery, IEnumerable<SelecionarServicoByIdQueryResponse>>
    {
        public Task<IEnumerable<SelecionarServicoByIdQueryResponse>> Handle(SelecionarServicoFiltersQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
