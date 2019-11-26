using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Pattern_ {
    public interface IRandomGUIDProvider {
        Guid RandomGUID { get; }
    }
}
