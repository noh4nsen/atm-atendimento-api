using Atm.Atendimento.Dto;
using Atm.Atendimento.Services;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IConfiguration _configuration;

        public ClienteService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<CarroOrcamento> GetCarroById(Guid id)
        {
            RestClient client = new RestClient(_configuration.GetValue<string>("api:cliente"));
            RestRequest request = new RestRequest("carro/{id}", Method.Get);
            request.AddParameter("id", id);
            RestResponse<CarroOrcamento> result = await client.ExecuteAsync<CarroOrcamento>(request);
            return result.Data;
        }

        public async Task<ClienteOrcamento> GetClienteById(Guid id)
        {
            RestClient client = new RestClient(_configuration.GetValue<string>("api:cliente"));
            RestRequest request = new RestRequest("cliente/{id}", Method.Get);
            request.AddParameter("id", id);
            RestResponse<ClienteOrcamento> result = await client.ExecuteAsync<ClienteOrcamento>(request);
            return result.Data;
        }
    }
}
