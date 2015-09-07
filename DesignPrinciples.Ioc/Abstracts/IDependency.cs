using System;

namespace DesignPrinciples.Ioc.Abstracts
{
    public interface IDependency
    {
        Type AbstractType { get; set; }

        Type ConcreteType { get; set; }

        object Instance { get; set; }

        InstantiationScope Scope { get; set; }

        void CreateInstance(params object[] args);
    }
}
