using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModels.Models
{
    public class ClientModel:INotifyPropertyChanged
    {
        public string ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public int? CallsToCenter { get; set; }
        
        public int? ClientTypeId { get; set; }
        public ClientTypeModel ClientType { get; set; }

        public ICollection<PaymentModel> Payments { get; set; }
        public ICollection<LineModel> Lines { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
