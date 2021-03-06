﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ClientTypeEntity
    {
            [Key]
            public int ClientTypeId { get; set; }
            public string TypeName { get; set; }
            public double? MinutePrice { get; set; }
            public double? SMSPrice { get; set; }
            public virtual ICollection<ClientEntity> Clients { get; set; }
    }
}
