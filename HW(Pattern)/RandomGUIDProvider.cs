using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Pattern_ {
    public class RandomGUIDProvider : IRandomGUIDProvider {
        public Guid RandomGUID { get; } = Guid.NewGuid();
    }
}
