using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using Atm.Atendimento.Domain;
using System;

namespace Atm.Atendimento.Api.Extensions.Entities
{
    public static class CustoServicoExtensions
    {
        public static CustoServico ToDomain(this InserirCustoServicoCommand request, Servico servico)
        {
            return new CustoServico()
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                Servico = servico,
                Valor = request.Valor,
                Descricao = request.Descricao,
                DataCadastro = DateTime.Now
            };
        }
    }
}
