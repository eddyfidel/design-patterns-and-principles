using DesignPatterns.Factory.Repositories;
using DesignPatterns.Factory.Utilities;
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

            var descriptionOrder = order.Description();

            var descriptionProduct = product.Description();
        }
    }
}
