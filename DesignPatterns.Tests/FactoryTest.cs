using DesignPatterns.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void CreateInstance()
        {
            var order = RepositoryFactory.CreateInstance<OrderRepository>();

            var product = RepositoryFactory.CreateInstance<ProductRepository>();

            var order2 = RepositoryFactory.CreateInstance<OrderRepository>();

            var isEquals = ReferenceEquals(order, order2);

            var isEquals2 = ReferenceEquals(order, order);

            var descriptionOrder = order.Description();

            var descriptionProduct = product.Description();
        }
    }
}
