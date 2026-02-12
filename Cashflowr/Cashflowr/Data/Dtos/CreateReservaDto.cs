using Cashflowr.Enums;
using System.ComponentModel.DataAnnotations;

namespace Cashflowr.Data.Dtos
{
    public class CreateReservaDto
    {
        [Required(ErrorMessage = "Nome da reserva é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Tipo da reserva é obrigatório.")]
        public TipoReserva? Tipo { get; set; }

        [Required(ErrorMessage = "Valor da reserva é obrigatório.")]
        [Range(0.01, 1_000_000, ErrorMessage = "Valor deve ser maior que zero.")]
        public decimal Valor { get; set; }
    }
}
