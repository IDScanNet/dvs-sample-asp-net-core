using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class DocumentVerificationResult
    {
        public int status { get; set; }
        public Confidence verificationConfidence { get; set; }
        public int totalConfidence { get; set; }

    }
}
