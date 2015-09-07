using System.Collections.Generic;
using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Utilities.Abstracts;

namespace DesignPatterns.Builder.Utilities.Builders
{
    public class EggplantLasagneBuilder : LasagneBuilderBase
    {
        public override void BuildLasagneType()
        {
            Lasagne.Type = LasagneType.Eggplant;
        }

        public override void AssignCondiment()
        {
            Lasagne.Condiments = new List<Condiment>
            {
                new Condiment
                {
                    Name = "Berenjenas grandes",
                    Quantity = 2,
                    Measure = "Unidad"
                },
                new Condiment
                {
                    Name = "Tomates maduros",
                    Quantity = 2,
                    Measure = "Unidad"
                },
                new Condiment
                {
                    Name = "Espárragos verdes",
                    Quantity = 1,
                    Measure = "Docena"
                },
                new Condiment
                {
                    Name = "Jamón cocido",
                    Quantity = 2,
                    Measure = "Longas"
                }
            };
        }
    }
}
