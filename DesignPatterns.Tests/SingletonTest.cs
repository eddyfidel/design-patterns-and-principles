using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void GetInstance()
        {
            var id1 = Singleton.Singleton.Instance;

            var id2 = Singleton.Singleton.Instance;

            var isEquals = ReferenceEquals(id1, id2);
        }
    }
}
