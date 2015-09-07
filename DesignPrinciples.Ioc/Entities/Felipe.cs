using DesignPrinciples.Ioc.Entities.Abstracts;

namespace DesignPrinciples.Ioc.Entities
{
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
}
