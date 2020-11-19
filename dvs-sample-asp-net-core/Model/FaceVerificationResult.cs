using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class FaceVerificationResult
    {
        public int confidence { get; set; }
        public FaceAnalytics faceAnalytics { get; set; }
    }
}
