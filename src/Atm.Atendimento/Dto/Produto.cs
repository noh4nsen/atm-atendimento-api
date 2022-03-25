using Atm.Atendimento.Domain;
using System;

namespace Atm.Atendimento.Dto
{
    public class Produto
    {
        public Guid Id { get; set; }
        public Orcamento Orcamento { get; set; }
    }
}
