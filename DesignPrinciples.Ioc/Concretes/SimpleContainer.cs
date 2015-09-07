using System;
using System.Collections.Generic;
using System.Linq;
using DesignPrinciples.Ioc.Abstracts;

namespace DesignPrinciples.Ioc.Concretes
{
    public class SimpleContainer : ISimpleContainer
    {
        private readonly IList<IDependency> _dependencies = new List<IDependency>();

        public void Register<TAbstract, TConcrete>()
        {
            Register<TAbstract, TConcrete>(InstantiationScope.Singleton);
        }

        public void Register<TAbstract, TConcrete>(InstantiationScope scope)
        {
            _dependencies.Add(new Dependency(typeof (TAbstract), typeof (TConcrete), scope));
        }

        public TAbstract Resolve<TAbstract>()
        {
            return (TAbstract) ResolveDependency(typeof (TAbstract));
        }

        public object Resolve(Type type)
        {
            return ResolveDependency(type);
        }

        private object ResolveDependency(Type type)
        {
            var dependency = _dependencies.FirstOrDefault(d => d.AbstractType == type);

            if (dependency == null)
            {
                throw new NullReferenceException(string.Format(
                    "The type {0} has not been registered in the container.", type.Name));
            }

            return GetInstance(dependency);
        }

        private object GetInstance(IDependency dependency)
        {
            if (dependency.Instance == null || dependency.Scope == InstantiationScope.NonSingleton)
            {
                var parameters = ResolveConstructorParameters(dependency);

                dependency.CreateInstance(parameters.ToArray());
            }

            return dependency.Instance;
        }

        private IEnumerable<object> ResolveConstructorParameters(IDependency dependency)
        {
            var constructorInfo = dependency.ConcreteType.GetConstructors().First();

            var parameters = constructorInfo.GetParameters();

            foreach (var parameter in parameters)
            {
                yield return ResolveDependency(parameter.ParameterType);
            }
        }
    }
}
