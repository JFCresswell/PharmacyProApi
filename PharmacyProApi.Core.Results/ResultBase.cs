using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results
{
    // all result classes will have these basic properties
    public class ResultBase
    {
        public int ResultCode { get; set; }

        public string ResultMessage { get; set; }
    }
}
