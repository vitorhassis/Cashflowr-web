using System;
namespace Cashflow.Models;

public class Contas
{
	public int Id { get; set; }
	public int IdUsuario { get; set; }
	public string Nome { get; set; }
	public decimal Valor { get; set; }
	public DateTime DataPago { get; set; } = DateTime.Now;
	public bool IsPlanejado { get; set; }
	
}
