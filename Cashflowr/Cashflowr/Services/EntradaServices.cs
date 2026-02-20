using CashFlowr.Data;

namespace Cashflowr.Service
{
    public class EntradaServices
    {
        private readonly MyCashContext _context;

        public EntradaServices(MyCashContext context)
        {
            _context = context;
        }

    }
}
