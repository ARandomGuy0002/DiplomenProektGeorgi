using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwordParadise.Abstraction;
using SwordParadise.Models.Statistics;

namespace SwordParadise.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StatisticsController : Controller
    {
        private readonly IStatisticsService statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        { this.statisticsService = statisticsService; }
        public IActionResult Index()
        {
            StatisticsVM statistics = new StatisticsVM();
            statistics.CountClients = statisticsService.CountClients();
            statistics.CountWeapons = statisticsService.CountWeapons();
            statistics.CountOrders = statisticsService.CountOrders();
            statistics.SumOrders = (int)statisticsService.SumOrders();

            return View(statistics);
        }
    }
}
