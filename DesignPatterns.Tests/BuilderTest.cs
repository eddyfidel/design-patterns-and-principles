using DesignPatterns.Builder.Utilities;
using DesignPatterns.Builder.Utilities.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void BuilderLasagne()
        {
            var meatLasagneCreator = new LasagneCreator(new MeatLasagneBuilder());

            var meatLasagne = meatLasagneCreator.CreateLasagne();

            var eggplantLasagneCreator = new LasagneCreator(new EggplantLasagneBuilder());

            var eggplantLasagne = eggplantLasagneCreator.CreateLasagne();
        }
    }
}
