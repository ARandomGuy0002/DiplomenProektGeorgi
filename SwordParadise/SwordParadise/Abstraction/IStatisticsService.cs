namespace SwordParadise.Abstraction
{
    public interface IStatisticsService
    {
        int CountWeapons();
        int CountClients();
        int CountOrders();
        decimal SumOrders();
    }
}
