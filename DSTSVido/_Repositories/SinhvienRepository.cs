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
using System.Configuration;

namespace DSTSVido._Repositories
{
    public class SinhvienRepository : BaseRepository, ISinhvienReposity
    {
        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
        public async Task<string> GetAll()
        {
            Console.WriteLine(settings[1].Name);
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = client.GetAsync(settings[1].ConnectionString).GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<string> GetDiemdanh(Diemdanh model)
        {
            HttpClient client = new HttpClient();
            diemdanhSendDto diemdanhs = new diemdanhSendDto();
            diemdanhs.Lop = model.Lop;
            string searchDiemdanh = JsonConvert.SerializeObject(diemdanhs);
            HttpContent c = new StringContent(searchDiemdanh, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PostAsync(settings[2].ConnectionString, c).GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }
        public async Task<string> GetDiemdanhHeader(DiemdanhHeaderSendDTO model)
        {
            HttpClient client = new HttpClient();
            DiemdanhHeaderSendDTO diemdanhs = new DiemdanhHeaderSendDTO();
            diemdanhs.Lop = model.Lop;
            string searchDiemdanh = JsonConvert.SerializeObject(diemdanhs);
            HttpContent c = new StringContent(searchDiemdanh, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PostAsync(settings[2].ConnectionString + "/header", c).GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }
        public IEnumerable<Diemdanh> GetByValue(string Lop)
        {
            var ListData = new List<Diemdanh>();
            var diemdanh = new Diemdanh();
            diemdanh.Lop = Lop.ToString();
            
            ListData.Add(diemdanh);
            return ListData;
        }

        public async Task<string> InsertData(Sinhvien model)
        {
            HttpClient client = new HttpClient();
            string sinhvien = JsonConvert.SerializeObject(model);
            HttpContent c = new StringContent(sinhvien, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PostAsync(settings[1].ConnectionString, c).GetAwaiter().GetResult(); 
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<string> UpdateData(Sinhvien model)
        {
            HttpClient client = new HttpClient();
            string sinhvien = JsonConvert.SerializeObject(model);
            HttpContent c = new StringContent(sinhvien, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PutAsync(settings[1].ConnectionString + "/" + model.id, c).GetAwaiter().GetResult(); //check doi link api
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }

        public IEnumerable<DiemdanhHeaderSendDTO> GetByValueHeader(string Lop)
        {
            var ListData = new List<DiemdanhHeaderSendDTO>();
            var diemdanh = new DiemdanhHeaderSendDTO();
            diemdanh.Lop = Lop.ToString();
            ListData.Add(diemdanh);
            return ListData;
        }

        public async Task<string> GetApicboxLop()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = client.GetAsync(settings[2].ConnectionString + "/lop").GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }
        
    }
}
