using System.Collections.Generic;
using DesignPatterns.Builder.Entities.Abstracts;
using DesignPatterns.Builder.Utilities;

namespace DesignPatterns.Builder.Entities
{
    public class Lasagne : ILasagne
    {
        public LasagneType Type { get; set; }
        
        public ICollection<Condiment> Condiments { get; set; }
    }
}
