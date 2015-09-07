using System;
using DesignPrinciples.Ioc.Abstracts;

namespace DesignPrinciples.Ioc.Concretes
{
    public class Dependency : IDependency
    {
        public Type AbstractType { get; set; }
        
        public Type ConcreteType { get; set; }
        
        public object Instance { get; set; }
        
        public InstantiationScope Scope { get; set; }
                                                                                                                                                                         
        public Dependency(Type abstractType, Type concreteType, InstantiationScope scope)
        {
            AbstractType = abstractType;
            
            ConcreteType = concreteType;
            
            Scope = scope;
        }

        public void CreateInstance(params object[] args)
        {
            Instance = Activator.CreateInstance(ConcreteType, args);
        }
    }
}
