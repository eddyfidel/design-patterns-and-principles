using System.Collections.Generic;
using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Utilities.Abstracts;

namespace DesignPatterns.Builder.Utilities.Builders
{
    public class MeatLasagneBuilder : LasagneBuilderBase
    {
        public override void BuildLasagneType()
        {
            Lasagne.Type = LasagneType.Meat;
        }

        public override void AssignCondiment()
        {
            Lasagne.Condiments = new List<Condiment>
            {
                new Condiment
                {
                    Name = "Carne picada de ternera",
                    Quantity = 300,
                    Measure = "Gramos"
                },
                new Condiment
                {
                    Name = "Carne picada de ternera",
                    Quantity = 200,
                    Measure = "Gramos"
                },
                new Condiment
                {
                    Name = "Bacon ahumado",
                    Quantity = 2,
                    Measure = "Longas"
                }
            };
        }
    }
}
