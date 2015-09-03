using DesignPrinciples.Ioc;
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

            container.Register<IAnimal, Animal>();
            container.Register<IWolf, Wolf>();
            container.Register<IFeline, Feline>();

            var animal = (IAnimal) container.Resolve(typeof (IAnimal));

            var feline = (IFeline) container.Resolve(typeof(IFeline));

            var sound = animal.Roar();
        }
    }

    public interface IAnimal
    {
        string Roar();
    }

    public class Animal : IAnimal
    {
        private readonly IWolf _wolf;

        public Animal(IWolf wolf)
        {
            _wolf = wolf;
        }

        public string Roar()
        {
            return _wolf.Roar();
        }
    }

    public interface IFeline
    {
        string Roar();
    }

    public class Feline : IFeline
    {
        private readonly IWolf _wolf;

        public Feline(IWolf wolf)
        {
            _wolf = wolf;
        }

        public string Roar()
        {
            return _wolf.Roar();
        }
    }

    public interface IWolf
    {
        string Guid { get; set; }

        string Roar();
    }

    public class Wolf : IWolf
    {
        public string Guid { get; set; }

        public Wolf()
        {
            Guid = System.Guid.NewGuid().ToString();
        }
        
        public string Roar()
        {
            return "Awwwwff";
        }
    }
}
