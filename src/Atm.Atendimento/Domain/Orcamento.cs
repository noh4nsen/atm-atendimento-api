using Atm.Atendimento.Dto;
using System;
using System.Collections.Generic;

namespace Atm.Atendimento.Domain
{
    public class Orcamento : Entity
    {
        public Cliente Cliente { get; set; }
        public Carro Carro { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
        public ICollection<Peca> Pecas { get; set; }
        public ICollection<CustoServico> CustoServicos { get; set; }
        public string Descricao { get; set; }
        public decimal? Desconto { get; set; }
        public decimal ValorFinal { get; set; }
        public int[] ModoPagamento { get; set; }
        public int Status { get; set; }
        public DateTime? DataAgendamento { get; set; }
        public DateTime? DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; }
        public double? Duracao { get; set; }

        // Pode ser usado para calcular duracao
        //public string tteste()
        //{
        //    var a = ((DateTime)DataHoraInicio - (DateTime)DataHoraFim).TotalHours;
        //}
    }
}
