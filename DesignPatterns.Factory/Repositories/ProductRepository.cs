namespace DesignPatterns.Factory.Repositories
{
    public class ProductRepository : IRepository
    {
        public string Description()
        {
            return "Product";
        }
    }
}
