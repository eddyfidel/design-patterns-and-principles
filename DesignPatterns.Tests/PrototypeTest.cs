using DesignPatterns.Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void DocumentPrototype()
        {
            var document = new Document("Homepage", "Welcome to my homepage");

            var documentPrototype = (Document) document.Clone();
        }
    }
}
