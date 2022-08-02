using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTSVido.Models;

namespace DSTSVido.Models
{
    public interface ISinhvienReposity
    {
        Task<string> GetAll();
        Task<string> UpdateData(Sinhvien model);
        Task<string> InsertData(Sinhvien model);
    }
}
