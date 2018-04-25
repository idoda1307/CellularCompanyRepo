using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels.Models
{
    public class PackageIncludesModel
    {
        public int Id { get; set; }
        public string IncludeName { get; set; }
        public int MaxMinute { get; set; }
        public double FixedPrice { get; set; }
        public double DiscountPrecentage { get; set; }
        public bool MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }
        
        public int FavoriteNumbersId { get; set; }
        public SelectedNumbersModel SelectedNumber { get; set; }
        
        public int PackageId { get; set; }
        public PackageModel Package { get; set; }
    }
}
