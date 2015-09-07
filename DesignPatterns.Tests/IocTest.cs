using DesignPrinciples.Ioc.Concretes;
using DesignPrinciples.Ioc.Entities;
using DesignPrinciples.Ioc.Entities.Abstracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class IocTest
    {
        [TestMethod]
        public void RegisterContainer()
        {
            var container = new SimpleContainer();

            container.Register<IWolf, Wolf>();
            container.Register<IFeline, Feline>();

            var feline1 = (IFeline) container.Resolve(typeof(IFeline));

            var feline2 = (IFeline) container.Resolve(typeof (IFeline));

            var roaring = feline1.Roar();
        }
    }
}
