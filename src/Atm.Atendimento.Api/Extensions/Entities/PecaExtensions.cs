using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using Atm.Atendimento.Api.Features.Orçamentos.Queries.SelecionarOrcamentoByIdFeature;
using Atm.Atendimento.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atm.Atendimento.Api.Extensions.Entities
{
    public static class PecaExtensions
    {
        public static Peca ToDomain(this InserirPecaCommand request)
        {
            return new Peca()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Nome = request.Nome,
                Descricao = request.Descricao,
                ValorUnitario = request.ValorUnitario,
                ValorCobrado = request.ValorCobrado,
                DataCadastro = DateTime.Now
            };
        }

        public static IEnumerable<SelecionarPecaQueryResponse> ToQueryResponse(this ICollection<Peca> list)
        {
            if (list.Count == 0 && !list.Any())
                return new List<SelecionarPecaQueryResponse>();

            IList<SelecionarPecaQueryResponse> pecas = new List<SelecionarPecaQueryResponse>();
            foreach (var entity in list)
                pecas.Add(entity.ToQueryResponse());
            return pecas;
        }

        public static SelecionarPecaQueryResponse ToQueryResponse(this Peca entity)
        {
            return new SelecionarPecaQueryResponse()
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Descricao = entity.Descricao,
                ValorUnitario = entity.ValorUnitario,
                ValorCobrado = entity.ValorCobrado
            };
        }
    }
}
