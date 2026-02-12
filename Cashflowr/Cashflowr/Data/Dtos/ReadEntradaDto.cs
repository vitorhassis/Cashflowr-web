using Cashflowr.Enums;

namespace Cashflowr.Data.Dtos
{
    public class ReadEntradaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
