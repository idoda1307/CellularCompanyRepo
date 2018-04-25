
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SelectedNumbersEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string ThirdNumber { get; set; }

        public ICollection<PackageIncludesEntity> PackageIncludes { get; set; }
    }
}
