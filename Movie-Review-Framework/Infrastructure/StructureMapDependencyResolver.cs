using System.Linq;
using System.Web.Mvc;
using System;
using StructureMap;
using System.Collections.Generic;

namespace Movie_Review_Framework.Infrastructure
{
    public class StructureMapDependencyResolver : IDependencyResolver
    {
        private readonly Func<IContainer> _factory;

        public StructureMapDependencyResolver(Func<IContainer> factory)
        {
            _factory = factory;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                return null;
            }

            var factory = _factory();

            return serviceType.IsAbstract || serviceType.IsInterface
                ? factory.TryGetInstance(serviceType)
                : factory.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _factory().GetAllInstances(serviceType).Cast<object>();
        }
    }
}