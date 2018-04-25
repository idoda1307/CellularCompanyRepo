using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ClientEntity
    {
        [Key]
        public string ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int? CallsToCenter { get; set; }
        
        [ForeignKey("ClientType")]
        public int? ClientTypeId { get; set; }
        public ClientTypeEntity ClientType { get; set; }

        public virtual ICollection<PaymentEntity> Payments { get; set; }
        public virtual ICollection<LineEntity> Lines { get; set; }

    }
}
