using SwordParadise.Abstraction;
using SwordParadise.Data;
using System.Linq;

namespace SwordParadise.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ApplicationDbContext _context;

        public StatisticsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public int CountClients()
        {

            return _context.Users.Count() - 1;
        }

        public int CountOrders()
        {
            return _context.Orders.Count();
        }

        public int CountWeapons()
        {
            return _context.Weapons.Count();
        }

        public decimal SumOrders()
        {
            return _context.Orders.Sum(x => x.Quantity * x.Price - x.Quantity * x.Price * x.Discount / 100);
        }
    }
}
