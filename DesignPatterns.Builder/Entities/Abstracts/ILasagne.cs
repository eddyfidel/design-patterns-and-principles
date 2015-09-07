using System.Collections.Generic;
using DesignPatterns.Builder.Utilities;

namespace DesignPatterns.Builder.Entities.Abstracts
{
    public interface ILasagne
    {
        LasagneType Type { get; set; }

        ICollection<Condiment> Condiments { get; set; }
    }
}
