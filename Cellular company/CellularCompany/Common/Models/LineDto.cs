using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    [DataContract]
    public class LineDto
    {
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ClientId { get; set; }
        [DataMember]
        public ClientDto Client { get; set; }

        [DataMember]
        public int PackageId { get; set; }
        [DataMember]
        public PackageDto Package { get; set; }

        public ICollection<SMSDto> SMS { get; set; }
        public ICollection<CallsDto> Calls { get; set; }
    }
}
