using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Pattern_.Dependency_Injection {
    class DIServiceColection {
        private List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();

        public void RegisterSingleton<TService>() {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Singleton));
        }
        public void RegisterSingleton<TService>(TService implementation) {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation,ServiceLifetime.Singleton));
        }
        public void RegisterSingleton<TService, TImplemention>() {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplemention), ServiceLifetime.Singleton));
        }
        public void RegisterTransient<TService>() {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), ServiceLifetime.Transient));
        }
        public void RegisterTransient<TService,TImplemention>() {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService),typeof(TImplemention), ServiceLifetime.Transient));
        }


        internal DIContainer GenerateContainer() {
            return new DIContainer(_serviceDescriptors);
        }
    }
}
