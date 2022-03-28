using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using Atm.Atendimento.Api.Features.Orçamentos.Queries.SelecionarOrcamentoByIdFeature;
using Atm.Atendimento.Domain;
using Atm.Atendimento.Domain.Enum;
using Atm.Atendimento.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Atm.Atendimento.Api.Extensions.Entities
{
    public static class OrcamentoExtensions
    {
        public static Orcamento ToDomain
            (
                this InserirOrcamentoCommand request,
                ClienteOrcamento cliente,
                CarroOrcamento carro,
                IEnumerable<ProdutoOrcamento> produtos,
                IEnumerable<Peca> pecas,
                IEnumerable<CustoServico> custoServicos,
                Pagamento pagamento
            )
        {
            return new Orcamento()
            {
                Ativo = true,
                Cliente = cliente,
                Carro = carro,
                Produtos = produtos.ToList(),
                Pecas = pecas.ToList(),
                CustoServicos = custoServicos.ToList(),
                Descricao = request.Descricao,
                Pagamento = pagamento,
                Status = StatusEnum.Cadastrado
            };
        }

        public static InserirOrcamentoCommandResponse ToInsertResponse(this Orcamento entity)
        {
            return new InserirOrcamentoCommandResponse()
            {
                Id = entity.Id,
                Datacadastro = entity.DataCadastro
            };
        }

        public static SelecionarOrcamentoByIdQueryResponse ToQueryResponse(this Orcamento entity)
        {
            return new SelecionarOrcamentoByIdQueryResponse()
            {
                Id = entity.Id,
                ClienteId = entity.Cliente.IdExterno,
                CarroId = entity.Carro.IdExterno,
                Descricao = entity.Descricao,
                ProdutoOrcamentos = entity.Produtos.ToQueryResponse().ToList(),
                Pecas = entity.Pecas.ToQueryResponse().ToList(),
                CustoServicos = entity.CustoServicos.ToQueryResponse().ToList(),
                Pagamento = entity.Pagamento.ToQueryResponse(),
                DataAgendamento = entity.DataAgendamento,
                DataHoraInicio = entity.DataHoraInicio,
                DataHoraFim = entity.DataHoraFim,
                Duracao = entity.Duracao               
            };
        }
    }
}
