using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces.RepositoryInterfaces
{
    public interface ILineRepository
    {
        Task<LineDto> CreateLine(LineDto line);
        Task<bool> DeleteLine(string number);
        Task<LineDto> UpdateLine(LineDto line, string clientId);
        LineDto GetLineByNumber(string number);
        IEnumerable<LineDto> GetLines();
        LineDto GetLine(int lineId);
        //LineDto FindLineByNumber(string number);
        //IEnumerable<string> GetLinesNumbers();
    }
}
