using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using Atm.Atendimento.Dto;
using System;

namespace Atm.Atendimento.Api.Extensions.Entities
{
    public static class ProdutoOrcamentoExtensions
    {
        public static ProdutoOrcamento ToDomain(this InserirProdutoCommand request, ProdutoOrcamento entity)
        {
            return new ProdutoOrcamento()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                IdExterno = entity.IdExterno,
                Quantidade = request.Quantidade,
                Percentual = request.Percentual,
                ValorTotal = request.ValorTotal,
                DataCadastro = DateTime.Now
            };
        }
    }
}
