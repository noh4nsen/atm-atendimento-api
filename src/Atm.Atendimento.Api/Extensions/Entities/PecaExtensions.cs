using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using Atm.Atendimento.Domain;
using System;

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
    }
}
