using Cashflowr.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace Cashflow.Models;
public class Entradas
{
    [Key]
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public NomeEntrada Nome { get; set; }
	public double Valor { get; set; }
}
