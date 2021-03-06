﻿using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces
{
    public interface ISMSManager
    {
        Task<SMSDto> AddSMSDto(SMSDto dto);
        Task<bool> RemoveSMSDto(int smsId);
        Task<SMSDto> UpdateSMSDto(SMSDto dto);
        SMSDto GetSMSDto(int smsId);
        IEnumerable<SMSDto> GetSMSDtos();
    }
}
