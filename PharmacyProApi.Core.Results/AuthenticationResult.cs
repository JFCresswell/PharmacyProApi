using PharmacyProApi.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results
{
    public class AuthenticationResult : ResultBase
    {
        public AuthenicationState AuthenticationState { get; set; }
    }
}
