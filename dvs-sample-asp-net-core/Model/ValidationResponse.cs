using dvs_sample_asp_net_core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dvs_sample_asp_net_core
{
    public class ValidationResponse
    {
        public Guid requestId { get; set; }

        public int documentType { get; set; }

        public Visual visual { get; set; }
        public MachineReadable machinereadable { get; set; }

        public string facePhotoFromDocument { get; set; }

        public string facePhoto { get; set; }

        public string signature { get; set; }

        public DocumentVerificationResult documentVerificationResult { get; set; }
        public FaceVerificationResult faceVerificationResult { get; set; }

        public Request request { get; set; }


        public string userAgent { get; set; }

        public string captureMethod { get; set; }
    }

}
