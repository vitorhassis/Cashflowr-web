using System;
namespace Cashflow.Models;

public class Contas
{
	public int id { get; set; }
	public int idUsuario { get; set; }
	public string nome { get; set; }
	public decimal valor { get; set; }
	public DateTime dataPago { get; set; } = DateTime.Now;
	public bool isPlanejado { get; set; }
	
}
