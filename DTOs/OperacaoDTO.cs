namespace Desafio.DTOs
{
    public class OperacaoDTO
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double PrimeiroValor { get; set; }
        public double SegundoValor { get; set; }
        public string Operador { get; set; } = string.Empty; // +, -, *, /
        public double? Resultado { get; set; }
    }
}