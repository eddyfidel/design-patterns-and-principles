namespace DesignPatterns.Factory.Repositories
{
    public class OrderRepository : IRepository
    {
        public string Description()
        {
            return "Order";
        }
    }
}
