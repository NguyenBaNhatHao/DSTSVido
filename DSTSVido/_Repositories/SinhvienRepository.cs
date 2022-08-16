using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DSTSVido.Models;
using System.Net.Http;
using DSTSVido.Dtos;
using Newtonsoft.Json;

namespace DSTSVido._Repositories
{
    public class SinhvienRepository : BaseRepository, ISinhvienReposity
    {

        public async Task<string> GetAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = client.GetAsync("https://admintt.viendong.edu.vn/api/sinhvien").GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<string> GetDiemdanh(Diemdanh model)
        {
            HttpClient client = new HttpClient();
            diemdanhSendDto diemdanhs = new diemdanhSendDto();
            diemdanhs.Lop = model.Lop;
            diemdanhs.Monhoc = model.Monhoc;
            diemdanhs.nguoiTao = model.nguoiTao;
            string searchDiemdanh = JsonConvert.SerializeObject(diemdanhs);
            HttpContent c = new StringContent(searchDiemdanh, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PostAsync("http://localhost:5032/api/diemdanh", c).GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }
        public IEnumerable<Diemdanh> GetByValue(string Lop, string Monhoc, string Nguoitao)
        {
            var ListData = new List<Diemdanh>();
            var diemdanh = new Diemdanh();
            diemdanh.Lop = Lop.ToString();
            diemdanh.Monhoc = Monhoc.ToString();
            diemdanh.nguoiTao = Nguoitao.ToString();
            ListData.Add(diemdanh);
            return ListData;
        }

        public async Task<string> InsertData(Sinhvien model)
        {
            HttpClient client = new HttpClient();
            string sinhvien = JsonConvert.SerializeObject(model);
            HttpContent c = new StringContent(sinhvien, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PostAsync("https://admintt.viendong.edu.vn/api/sinhvien", c).GetAwaiter().GetResult(); 
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<string> UpdateData(Sinhvien model)
        {
            HttpClient client = new HttpClient();
            string sinhvien = JsonConvert.SerializeObject(model);
            HttpContent c = new StringContent(sinhvien, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PutAsync("https://admintt.viendong.edu.vn/api/sinhvien/" + model.id, c).GetAwaiter().GetResult(); //check doi link api
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
