using Cashflowr.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class CreateEntradaDto
    {
        [Required(ErrorMessage = "Nome da entrada é obrigatório.")]
        public NomeEntrada? Nome { get; set; }
        [Required(ErrorMessage = "Valor da entrada é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal Valor { get; set; }
    }
}
