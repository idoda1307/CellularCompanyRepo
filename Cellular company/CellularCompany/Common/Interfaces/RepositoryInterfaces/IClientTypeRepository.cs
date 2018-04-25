﻿using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.RepositoryInterfaces
{
    public interface IClientTypeRepository
    {
        IEnumerable<ClientTypeDto> GetClientTypes();
        Task<List<ClientTypeDto>> AddOrUpdateClientType();
        Task<bool> DeleteClientType(int id);
        ClientTypeDto GetClientType(int id);
    }
}
