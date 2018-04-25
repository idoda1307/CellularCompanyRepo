using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces
{
    public interface IClientTypeManager
    {
        Task<IEnumerable<ClientTypeDto>> AddOrUpdateClientTypeDto();
        Task<bool> RemoveClientTypeDto(int typeId);
        ClientTypeDto GetClientTypeDto(int typeId);
        IEnumerable<ClientTypeDto> GetClientTypesDto();
    }
}
