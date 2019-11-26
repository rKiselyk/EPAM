using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Pattern_.Dependency_Injection {
    class ServiceDescriptor {
        public Type ServiceType { get; }
        public Type ImplementationType { get; }
        public object Implemention { get; internal set; }
        public ServiceLifetime LifeTime { get; }

        public ServiceDescriptor(object implemention, ServiceLifetime lifetime) {
            ServiceType = implemention.GetType();
            Implemention = implemention;
            LifeTime = lifetime;
        }
        public ServiceDescriptor(Type serviceType, ServiceLifetime lifetime) {
            ServiceType = serviceType;
            LifeTime = lifetime;
        }
        public ServiceDescriptor(Type serviceType,Type implementationType, ServiceLifetime lifetime) {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            LifeTime = lifetime;
        }
    }
}
