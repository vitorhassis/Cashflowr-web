using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class CreateMetaDto
    {
        [Required(ErrorMessage = "Nome da meta é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor da meta é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal ValorAlvo { get; set; }
    }
}
