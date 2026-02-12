using Cashflow.Models;
using Cashflowr.Data.Dtos;
using CashFlowr.Data;

namespace Cashflowr.Service
{
    public class ContasService
    {
        private readonly MyCashContext _context;
        public ContasService(MyCashContext context)
        {
            _context = context;
        }

        public void Criar(CreateContasDto contaDto)
        {
            if(contaDto.DataVencimento < DateTime.Today.AddYears(-1))
            {
                throw new ArgumentException("Data de vencimento inválida");
            }

            var conta = new Contas
            {
                Nome = contaDto.Nome,
                Valor = contaDto.Valor,
                DataVencimento = contaDto.DataVencimento,
                ValorPlanejado = contaDto.ValorPlanejado,
                IsPago = false,
                DataPagamento = null
            };

            _context.Contas.Add(conta);
            _context.SaveChanges();
        }

        public void Ler(CreateContasDto contaDto)
        {

        }
    }
}
