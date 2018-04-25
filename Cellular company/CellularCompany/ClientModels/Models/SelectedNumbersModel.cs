using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels.Models
{
    public class SelectedNumbersModel
    {
        public int Id { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string ThirdNumber { get; set; }

        public ICollection<PackageIncludesModel> PackageIncludes { get; set; }
    }
}
