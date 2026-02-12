using System;
namespace Cashflow.Models;

public class Contas
{
	public int Id { get; set; }
	public int IdUsuario { get; set; }
	public string Nome { get; set; }
	public decimal Valor { get; set; }
    public DateTime? DataPagamento { get; set; } //? significa que o campo pode ter uma data ou pode ser nullo. Isso porque, nem toda conta foi paga ainda.
	public DateTime DataVencimento { get; set; }
    public decimal ValorPlanejado { get; set; }

	public bool IsPago { get; set; } = false; //comeca como falso
	
}
