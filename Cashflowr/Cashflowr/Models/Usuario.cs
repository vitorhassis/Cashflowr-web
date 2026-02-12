using System;
using System.ComponentModel.DataAnnotations;
namespace Cashflow.Models;
public class Usuario
{
	[Key]
	public int Id {  get; set; }
	public String Nome { get; set; }
    public String Email { get; set; }
	public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
	public bool IsAtivo { get; set; }

	public string Senha { get; set; }
}
