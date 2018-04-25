using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.BLInterfaces.RepositoriesManagersInterfaces
{
    public interface ISelectedNumbersManager
    {
        Task<SelectedNumbersDto> AddSelectedNumberDto(SelectedNumbersDto dto);
        Task<bool> RemoveSelectedNumberDto(int numberId);
        Task<SelectedNumbersDto> UpdateSelectedNumberDto(SelectedNumbersDto dto);
        SelectedNumbersDto GetSelectedNumberDto(int numberId);
        IEnumerable<SelectedNumbersDto> GetSelectedNumberDtos();
    }
}
