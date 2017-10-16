using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProApi.Core.BusinessLogic.Pharmacy
{
    // Business Rules:
    // 1. A fully qualified user will have an entry in the machine history table set to active
    // 2. A new user will request access, adding a new entry in the machine history table with a confirmation code set, not yet active
    // 3. We need to throttle attempts to add a machine history item
    public class Authentication : IAuthentication
    {
    }
}
