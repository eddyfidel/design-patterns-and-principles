using DesignPrinciples.Ioc.Entities.Abstracts;

namespace DesignPrinciples.Ioc.Entities
{
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
