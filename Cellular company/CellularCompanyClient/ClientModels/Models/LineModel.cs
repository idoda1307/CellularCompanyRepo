using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels.Models
{
    public class LineModel
    {
        public int LineId { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        
        public string ClientId { get; set; }
        public ClientModel Client { get; set; }
        
        public int PackageId { get; set; }
        public PackageModel Package { get; set; }

        public ICollection<SMSModel> SMS { get; set; }
        public ICollection<CallsModel> Calls { get; set; }
    }
}
