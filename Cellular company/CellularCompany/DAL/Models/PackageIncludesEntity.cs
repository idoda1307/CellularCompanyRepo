﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PackageIncludesEntity
    {
        [Key]
        public int Id { get; set; }
        public string IncludeName { get; set; }
        public int MaxMinute { get; set; }
        public double FixedPrice { get; set; }
        public double DiscountPrecentage { get; set; }
        public bool MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }
        
        [ForeignKey("SelectedNumber")]
        public int FavoriteNumbersId { get; set; }
        public SelectedNumbersEntity SelectedNumber { get; set; }

        [ForeignKey("Package")]
        public int PackageId { get; set; }
        public PackageEntity Package { get; set; }
    }
}