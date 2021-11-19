using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMPG323Project2.Models
{
    public class ImagesModels
    {
        public int Images_ID { get; set; }
        public string Images_Name { get; set; }
        public double Images_Size { get; set; }
        public DateTime Images_DownloadDate{ get; set; }
        public byte[] Images_ActualPhoto { get; set; }
        public string Images_Url { get; set; }
    }
}
