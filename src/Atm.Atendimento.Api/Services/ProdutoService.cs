using Atm.Atendimento.Dto;
using Atm.Atendimento.Services;
using System;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Services
{
    public class ProdutoService : IProdutoService
    {
        public Task<ProdutoOrcamento> GetProdutoById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoOrcamento> PutProduto(ProdutoOrcamento produtoOrcamento)
        {
            throw new NotImplementedException();
        }
    }
}
