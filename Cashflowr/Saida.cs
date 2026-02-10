using System;
namespace Cashflow.Models;
public class Saida
{
	public int id {  get; set; }
	public int idUsuario { get; set; }
	public decimal valor { get; set; }
	public string categoria { get; set; }
	public string formaDePagamento { get; set; }
	public bool isEssencial { get; set; }
}
