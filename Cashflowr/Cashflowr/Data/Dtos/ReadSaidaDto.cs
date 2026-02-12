using Cashflowr.Enums;

namespace Cashflowr.Data.Dtos
{
    public class ReadSaidaDto
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }
        public string FormaDePagamento { get; set; }
        public bool IsEssencial { get; set; }

        public DateTime DataSaida { get; set; }
    }
}
