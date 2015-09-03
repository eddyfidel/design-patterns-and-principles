using System;

namespace DesignPrinciples.Ioc
{
    public interface ISimpleContainer
    {
        void Register<TAbstract, TConcrete>();

        void Register<TAbstract, TConcrete>(InstantiationScope scope);

        TAbstract Resolve<TAbstract>();

        object Resolve(Type type);
    }
}
