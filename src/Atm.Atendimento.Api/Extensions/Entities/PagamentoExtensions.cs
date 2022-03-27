using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using Atm.Atendimento.Domain;
using System;

namespace Atm.Atendimento.Api.Extensions.Entities
{
    public static class PagamentoExtensions
    {
        public static Pagamento ToDomain(this InserirPagamentoCommand request)
        {
            return new Pagamento()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Percentual = request.Percentual,
                Desconto = request.Desconto,
                ValorFinal = request.ValorFinal,
                PagamentoEfetuado = request.PagamentoEfetuado,
                ModoPagamento = request.ModoPagamento.ToDomain(),
                DataCadastro = DateTime.Now
            };
        }

        public static ModoPagamento ToDomain(this InserirModoPagamentoCommand request)
        {
            return new ModoPagamento()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                CartaoCredito = request.CartaoCredito,
                CartaoDebito = request.CartaoDebito,
                Dinheiro = request.Dinheiro,
                Pix = request.Pix,
                DataCadastro = DateTime.Now
            };
    }
    }
}
