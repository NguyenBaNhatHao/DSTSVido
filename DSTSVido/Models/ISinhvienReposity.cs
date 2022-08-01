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
        IEnumerable<Sinhvien> GetAll();
        void InsertData(Sinhvien model);
    }
}
