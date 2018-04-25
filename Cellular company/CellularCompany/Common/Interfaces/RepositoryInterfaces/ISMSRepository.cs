using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.RepositoryInterfaces
{
    public interface ISMSRepository
    {
        Task<SMSDto> CreateSMS(SMSDto sms);
        Task<bool> DeleteSMS(int id);
        Task<SMSDto> UpdateSMS(SMSDto sms);
        SMSDto GetSMS(int id);
        IEnumerable<SMSDto> GetSMSs();
    }
}
