using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.RepositoryInterfaces
{
    public interface ISelectedNumbersRepository
    {
        Task<SelectedNumbersDto> CreateSelectedNumber(SelectedNumbersDto number);
        Task<bool> DeleteSelectedNumber(int id);
        Task<SelectedNumbersDto> UpdateSelectedNumber(SelectedNumbersDto number);
        SelectedNumbersDto GetSelectedNumber(int id);
        IEnumerable<SelectedNumbersDto> GetSelectedNumbers();
    }
}
