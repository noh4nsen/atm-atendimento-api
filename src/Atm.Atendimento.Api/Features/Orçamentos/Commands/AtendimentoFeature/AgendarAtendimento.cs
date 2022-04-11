using Atm.Atendimento.Api.Extensions.Entities;
using Atm.Atendimento.Domain;
using Atm.Atendimento.Domain.Enum;
using Atm.Atendimento.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Orçamentos.Commands.AtendimentoFeature
{
    public class AgendarAtendimentoCommand : IRequest<AgendarAtendimentoCommandResponse>
    {
        public Guid Id { get; set; }
        public DateTime DataAgendamento { get; set; }
    }

    public class AgendarAtendimentoCommandResponse
    {
        public Guid Id { get; set; }
        public DateTime? DataAgendamento { get; set; }
    }

    public class AgendarAtendimentoCommandHandler : IRequestHandler<AgendarAtendimentoCommand, AgendarAtendimentoCommandResponse>
    {
        private readonly IRepository<Orcamento> _repository;
        private readonly AgendarAtendimentoCommandValidator _validator;

        public AgendarAtendimentoCommandHandler
            (
                IRepository<Orcamento> repository,
                AgendarAtendimentoCommandValidator validator
            )
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<AgendarAtendimentoCommandResponse> Handle(AgendarAtendimentoCommand request, CancellationToken cancellationToken)
        {
            if (request is null)
                throw new ArgumentNullException("Erro ao processar requisição.");

            Orcamento entity = await GetOrcamentoAsync(request, cancellationToken);
            await AgendarOrcamentoAsync(request, entity);

            return entity.ToAgendarResponse();
        }

        private async Task AgendarOrcamentoAsync(AgendarAtendimentoCommand request, Orcamento entity)
        {
            request.ToAgendamento(entity);
            await _repository.UpdateAsync(entity);
            await _repository.SaveChangesAsync();
        }

        private async Task<Orcamento> GetOrcamentoAsync(AgendarAtendimentoCommand request, CancellationToken cancellationToken)
        {
            Orcamento entity = await _repository.GetFirstAsync(o => o.Id.Equals(request.Id));
            await _validator.ValidateDataAsync(request, entity, cancellationToken);
            await _validator.ValidateDataAsync(request, entity.Status, cancellationToken);
            return entity;
        }
    }

    public class AgendarAtendimentoCommandValidator : AbstractValidator<AgendarAtendimentoCommand>
    {
        public AgendarAtendimentoCommandValidator()
        {
            RuleFor(r => r.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id de orçamento é obrigatório");
            RuleFor(r => r.DataAgendamento)
                .NotEmpty()
                .WithMessage("Data de agendamento é obrigatório.");
        }

        public async Task ValidateDataAsync
            (
                AgendarAtendimentoCommand request,
                Orcamento entity,
                CancellationToken cancellationToken
            )
        {
            RuleFor(r => r.Id)
                .Must(m => { return entity is not null; })
                .WithMessage($"Orçamento de id {request.Id} não encontrado.");
            await this.ValidateAndThrowAsync(request, cancellationToken);
        }

        public async Task ValidateDataAsync
            (
                AgendarAtendimentoCommand request,
                StatusEnum status,
                CancellationToken cancellationToken
            )
        {
            RuleFor(r => r.Id)
                .Must(m => { return status == StatusEnum.Cadastrado || status == StatusEnum.Agendado; })
                .WithMessage($"Orçamento de id {request.Id} já foi finalizado");
            await this.ValidateAndThrowAsync(request, cancellationToken);
        }
    }
}
