using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class UpdateContasDto
    {
        [Required(ErrorMessage = "Nome da conta é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor da conta é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Data da conta é obrigatória.")]
        public DateTime DataVencimento { get; set; }
        public decimal ValorPlanejado { get; set; }
    }
}
