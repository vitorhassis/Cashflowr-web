using Cashflowr.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class CreateContasDto
    {
        [Required(ErrorMessage = "Nome da conta é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor da conta é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Data do vencimento da conta é obrigatória.")]
        public DateTime DataVencimento { get; set; }

        [Required(ErrorMessage = "Valor planejado é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal ValorPlanejado { get; set; }

    }
}
