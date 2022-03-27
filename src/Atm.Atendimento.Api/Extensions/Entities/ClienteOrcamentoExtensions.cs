using Atm.Atendimento.Dto;
using System;

namespace Atm.Atendimento.Api.Extensions.Entities
{
    public static class ClienteOrcamentoExtensions
    {
        public static ClienteOrcamento ToNew(this ClienteOrcamento entity)
        {
            return new ClienteOrcamento()
            {
                Id = Guid.NewGuid(),
                IdExterno = entity.IdExterno,
                DataCadastro = DateTime.Now
            };
        }
    }
}
