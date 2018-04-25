using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels.Models
{
    public class PackageModel
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public double PackageTotalPrice { get; set; }

        public ICollection<LineModel> Lines { get; set; }
        public ICollection<PackageIncludesModel> PackageIncludes { get; set; }
    }
}
