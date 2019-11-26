using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Pattern_ {
    public class SomeServiceOne : ISomeService {
        //private readonly Guid RandomGuid = Guid.NewGuid();
        private readonly IRandomGUIDProvider _randomGUIDProvider;

        public SomeServiceOne(IRandomGUIDProvider randomGUIDProvider) {
            _randomGUIDProvider = randomGUIDProvider;
        }

        public void PrintSomething() {
            Console.WriteLine(_randomGUIDProvider.RandomGUID);
        }
    }
}
