using System;
namespace Cashflow.Models;
public class Meta
{
	public int id { get; set; }
	public string idUsuario { get; set; }
	public string nome { get; set; }
	public decimal valorAlvo { get; set; }
	public DateTime dataCriacao { get; set; } = DateTime.Now;
	
}
