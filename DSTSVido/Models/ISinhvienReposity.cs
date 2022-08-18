using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTSVido.Models;
using DSTSVido.Dtos;

namespace DSTSVido.Models
{
    public interface ISinhvienReposity
    {
        Task<string> GetAll();
        IEnumerable<Diemdanh> GetByValue(string Lop, string Monhoc, string Nguoitao, string Khoahoc);
        IEnumerable<DiemdanhHeaderSendDTO> GetByValueHeader(string Lop, string Monhoc, string Nguoitao, string Khoahoc);
        Task<string> GetDiemdanhHeader(DiemdanhHeaderSendDTO model);
        Task<string> GetDiemdanh(Diemdanh model);
        Task<string> UpdateData(Sinhvien model);
        Task<string> InsertData(Sinhvien model);
    }
}
