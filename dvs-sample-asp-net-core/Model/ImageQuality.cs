using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class ImageQuality
    {
        public int flare { get; set; }
        public int noise { get; set; }
        public int lighting { get; set; }
        public int sharpness { get; set; }
        public int total { get; set; }

    }
}
