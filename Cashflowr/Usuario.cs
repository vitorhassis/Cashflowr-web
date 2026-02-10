using System;
namespace Cashflow.Models;
public class Usuario
{
	public int Id {  get; set; }
	public String Nome { get; set; }
	public String Email { get; set; }
	public DateTime DataCriacao { get; set; } = DateTime.Now;
	public bool IsAtivo { get; set; }
}
