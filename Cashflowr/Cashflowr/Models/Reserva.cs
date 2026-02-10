using Cashflowr.Enums;
using System;
namespace Cashflow.Models;
public class Reserva
{
	public int Id { get; set; }
	public int IdUsuario { get; set; }
	public string Nome { get; set; }
	public TipoReserva Tipo { get; set; }
	public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
	public decimal Valor { get; set; }
}
