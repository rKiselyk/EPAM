using System;
using HW_Pattern_.Dependency_Injection;

namespace HW_Pattern_ {
    class Program {
        static void Main(string[] args) {
            var services = new DIServiceColection();

            //services.RegisterSingleton<RandomGIUDGeneretor>();
            //services.RegisterSingleton(new RandomGIUDGeneretor());
            //services.RegisterTransient<RandomGIUDGeneretor>();

            services.RegisterSingleton<ISomeService, SomeServiceOne>();
            services.RegisterTransient<IRandomGUIDProvider, RandomGUIDProvider>();

            var container = services.GenerateContainer();

            var serviceFirst = container.GetService<ISomeService>();
            var serviceSecond = container.GetService<ISomeService>();

            //Console.WriteLine(serviceFirst.RandomGuid);
            //Console.WriteLine(serviceSecond.RandomGuid);
            serviceFirst.PrintSomething();
            serviceSecond.PrintSomething();
        }
    }
}
