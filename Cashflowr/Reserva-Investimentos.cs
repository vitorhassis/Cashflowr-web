using System;
namespace Cashflow.Models;
public class Reserva
{
	public Reserva()
	{
	public int id { get; set; }
	public int idUsuario { get; set; }
	public string nome { get; set; }
	public string tipo { get; set; }
	public DateTime dataCriacao { get; set; } = DateTime.Now;
	public decimal valor { get; set; }
}
}
