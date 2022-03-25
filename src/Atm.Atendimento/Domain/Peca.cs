namespace Atm.Atendimento.Domain
{
    public class Peca : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorCobrado { get; set; }
        public Orcamento Orcamento { get; set; }
    }
}
