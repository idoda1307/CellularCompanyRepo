﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LineEntity
    {
        [Key]
        public int LineId { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        
        [ForeignKey("Package")]
        public int PackageId { get; set; }
        public PackageEntity Package { get; set; }
        
        [ForeignKey("Client")]
        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }

        public virtual ICollection<SMSEntity> SMS { get; set; }
        public virtual ICollection<CallsEntity> Calls { get; set; }
    }
}
