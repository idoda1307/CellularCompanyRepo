using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PackageEntity
    {
        [Key]
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public double PackageTotalPrice { get; set; }

        public virtual ICollection<LineEntity> Lines { get; set; }
        public PackageIncludesEntity PackageIncludes { get; set; }
        [ForeignKey("PackageIncludes")]
        public int PackageIncludesId { get; set; }
    }
}
