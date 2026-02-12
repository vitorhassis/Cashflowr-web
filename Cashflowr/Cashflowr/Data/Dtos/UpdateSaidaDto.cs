using Cashflowr.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class UpdateSaidaDto
    {
        [Required(ErrorMessage = "Valor da saída é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Tipo da despesa é obrigatório.")]
        public CategoriaDespesa? Categoria { get; set; }

        [Required(ErrorMessage = "Forma de pagamento é obrigatória.")]
        public FormaDePagamentoDespesa? FormaDePagamento { get; set; }

        [Required(ErrorMessage = "Data da despesa é obrigatória.")]
        public DateTime? DataSaida { get; set; }
        public bool IsEssencial { get; set; }
    }
}
