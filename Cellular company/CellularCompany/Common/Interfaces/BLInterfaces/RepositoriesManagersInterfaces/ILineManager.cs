using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces
{
    public interface ILineManager
    {
        Task<LineDto> AddLineDto(LineDto dto);
        Task<bool> RemoveLineDto(string number);
        Task<LineDto> UpdateLineDto(LineDto dto, string clientId);
        LineDto GetLineDto(string number);
        IEnumerable<LineDto> GetLineDtos();
    }
}
