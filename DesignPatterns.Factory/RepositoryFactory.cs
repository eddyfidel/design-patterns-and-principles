using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DesignPatterns.Factory
{
    public static class RepositoryFactory
    {
        private static readonly IList<Type> Repositories;

        static RepositoryFactory()
        {
            Repositories = new List<Type>();

            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (type.GetInterface(typeof (IRepository).ToString()) != null)
                {
                    Repositories.Add(type);
                }
            }
        }

        public static IRepository CreateInstance<TRepository>() where TRepository : IRepository
        {
            if (Repositories.All(r => r != typeof (TRepository)))
            {
                throw new ArgumentException(string.Format("{0} type does not exist in runtime.", typeof (TRepository)));
            }

            return (IRepository) Activator.CreateInstance(typeof (TRepository));
        }
    }
}
