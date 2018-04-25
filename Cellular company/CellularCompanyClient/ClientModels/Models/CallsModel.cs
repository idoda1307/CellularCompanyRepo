using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels.Models
{
    public class CallsModel
    {
        public int CallId { get; set; }
        public double Duration { get; set; }
        public double ExternalPrice { get; set; }
        public string DestinationNumber { get; set; }
        public int LineId { get; set; }
        public LineModel Line { get; set; }
    }
}
