using Cashflowr.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace Cashflow.Models;
public class Saida
{
	[Key]
    public int Id {  get; set; }
	public int IdUsuario { get; set; }
	public decimal Valor { get; set; }
    public CategoriaDespesa Categoria { get; set; }
	public FormaDePagamentoDespesa FormaDePagamento { get; set; }
	public bool IsEssencial { get; set; }
}
