using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
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
    }
}
