using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class Request
    {
     public Guid id { get; set; }

     public Guid accountId { get; set; }

     public int documentType { get; set; }
    public Content content { get; set; }
    public int status { get; set; }
    public DateTime created { get; set; }
    public bool ocrVisual { get; set; }
    }
}
