using Cashflowr.Enums;

namespace Cashflowr.Data.Dtos
{
    public class ReadReservaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal Valor { get; set; }
    }
}
