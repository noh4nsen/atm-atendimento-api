using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Servicos.Queries
{
    public class SelecionarServicoByIdQuery : IRequest<SelecionarServicoByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }

    public class SelecionarServicoByIdQueryResponse
    {

    }

    public class SelecionarServicoByIdQueryHandler : IRequestHandler<SelecionarServicoByIdQuery, SelecionarServicoByIdQueryResponse>
    {
        public Task<SelecionarServicoByIdQueryResponse> Handle(SelecionarServicoByIdQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    public class SelecionarServicoByIdQueryValidator : AbstractValidator<SelecionarServicoByIdQuery>
    {
        public SelecionarServicoByIdQueryValidator()
        {
        }
    }
}
