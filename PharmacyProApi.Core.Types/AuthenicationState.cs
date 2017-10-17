using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProApi.Core.Types
{
    public enum AuthenicationState : int
    {
        NotAuthenticated,
        UnrecognizedDeviceID,
        UnrecognizedDeviceName,
        Authenticated
    }
}
