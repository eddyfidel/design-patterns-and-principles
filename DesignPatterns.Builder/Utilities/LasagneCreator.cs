using DesignPatterns.Builder.Entities.Abstracts;
using DesignPatterns.Builder.Utilities.Abstracts;

namespace DesignPatterns.Builder.Utilities
{
    public class LasagneCreator
    {
        private readonly LasagneBuilderBase _lasagneBuilderBase;

        public LasagneCreator(LasagneBuilderBase lasagneBuilderBase)
        {
            _lasagneBuilderBase = lasagneBuilderBase;
        }

        public ILasagne CreateLasagne()
        {
            _lasagneBuilderBase.InitializeLasagne();
            _lasagneBuilderBase.BuildLasagneType();
            _lasagneBuilderBase.AssignCondiment();

            return _lasagneBuilderBase.Lasagne;
        }
    }
}
