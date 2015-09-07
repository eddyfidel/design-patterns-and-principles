using DesignPatterns.Builder.Entities;
using DesignPatterns.Builder.Entities.Abstracts;

namespace DesignPatterns.Builder.Utilities.Abstracts
{
    public abstract class LasagneBuilderBase
    {
        public ILasagne Lasagne { get; private set; }

        public void InitializeLasagne()
        {
            Lasagne = new Lasagne();
        }

        public abstract void BuildLasagneType();

        public abstract void AssignCondiment();
    }
}
