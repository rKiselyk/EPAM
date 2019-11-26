using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_Pattern_.Dependency_Injection {
    class DIContainer {
        private List<ServiceDescriptor> _serviceDescriptors;

        public DIContainer(List<ServiceDescriptor> serviceDescriptors) {
            _serviceDescriptors = serviceDescriptors;
        }

        public object GetService(Type serviceType) {
            var descriptor = _serviceDescriptors
                .SingleOrDefault(x => x.ServiceType == serviceType);

            if (descriptor == null) {
                throw new Exception($"Service of type {serviceType.Name} isn`t registered");
            }

            if (descriptor.Implemention != null) {
                return descriptor.Implemention;
            }

            var actualType = descriptor.ImplementationType ?? descriptor.ServiceType;

            if (actualType.IsAbstract || actualType.IsInterface) {
                throw new Exception("Cannot instattiante abstract class or interface");
            }

            var constructorInfo = actualType.GetConstructors().First();

            var parametres = constructorInfo.GetParameters().Select(x => GetService(x.ParameterType)).ToArray();

            var implementation = Activator.CreateInstance(actualType,parametres);

            if (descriptor.LifeTime == ServiceLifetime.Singleton) {
                descriptor.Implemention = implementation;
            }
            return implementation;
        }

        public T GetService<T>() {
            return (T)GetService(typeof(T));
        }
    }
}
