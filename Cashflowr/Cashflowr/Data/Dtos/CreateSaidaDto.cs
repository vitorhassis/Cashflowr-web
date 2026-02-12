using Cashflowr.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class CreateSaidaDto
    {
        [Required(ErrorMessage = "Valor da despesa é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Categoria da despesa é obrigatória.")]
        public CategoriaDespesa? Categoria { get; set; }


        [Required(ErrorMessage = "Forma de pagamento da despesa é obrigatória.")]
        public FormaDePagamentoDespesa? FormaDePagamento { get; set; }

        [Required(ErrorMessage = "Data da despesa é obrigatória.")]
        public DateTime? DataSaida { get; set; }
        public bool IsEssencial { get; set; }
    }
}
