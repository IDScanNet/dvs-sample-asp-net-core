using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class ErrorResponse
    {
       public string code { get; set; }
       public string message { get; set; }
       public string traceId { get; set; }
    }
}
