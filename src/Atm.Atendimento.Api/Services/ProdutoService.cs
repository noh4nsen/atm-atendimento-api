using Atm.Atendimento.Dto;
using Atm.Atendimento.Services;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IConfiguration _configuration;

        public ProdutoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<ProdutoOrcamento> GetProdutoById(Guid id)
        {
            RestClient client = new RestClient(_configuration.GetValue<string>("api:fornecedor"));
            RestRequest request = new RestRequest("produto/{id}", Method.Get).AddUrlSegment("id", id);
            RestResponse<ProdutoDto> result = await client.ExecuteAsync<ProdutoDto>(request);

            ProdutoDto produtoDto = result.Data;
            ProdutoOrcamento produto = new ProdutoOrcamento();

            if (produtoDto is null)
                return null;
            if (produtoDto.Id.Equals(Guid.Empty))
                return null;

            produto.IdExterno = produtoDto.Id;
            return produto;
        }

        public async Task<ProdutoOrcamento> PutProduto(ProdutoOrcamento produtoOrcamento)
        {
            throw new NotImplementedException();
        }

        private class ProdutoDto
        {
            public Guid Id { get; set; }
        }
    }
}
