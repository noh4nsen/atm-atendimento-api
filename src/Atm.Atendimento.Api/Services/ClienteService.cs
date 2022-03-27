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
            RestRequest request = new RestRequest("carro/{id}", Method.Get).AddUrlSegment("id", id);
            RestResponse<CarroDto> result = await client.ExecuteAsync<CarroDto>(request);

            CarroDto carroDto = result.Data;
            CarroOrcamento carro = new CarroOrcamento();

            if (carroDto.Id.Equals(Guid.Empty))
                return null;

            carro.IdExterno = carroDto.Id;
            return carro;
        }

        public async Task<ClienteOrcamento> GetClienteById(Guid id)
        {
            RestClient client = new RestClient(_configuration.GetValue<string>("api:cliente"));
            RestRequest request = new RestRequest("cliente/{id}", Method.Get).AddUrlSegment("id", id);
            RestResponse<ClienteDto> result = await client.ExecuteAsync<ClienteDto>(request);

            ClienteDto clienteDto = result.Data;
            ClienteOrcamento cliente = new ClienteOrcamento();

            if (clienteDto.Id.Equals(Guid.Empty))
                return null;

            cliente.IdExterno = clienteDto.Id;
            return cliente;
        }

        private class CarroDto
        {
            public Guid Id { get; set; }
        }

        private class ClienteDto
        {
            public Guid Id { get; set; }
        }
    }
}
