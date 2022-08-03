using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DSTSVido.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace DSTSVido._Repositories
{
    public class SinhvienRepository : BaseRepository, ISinhvienReposity
    {

        public async Task<string> GetAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponse = client.GetAsync("https://localhost:7070/api/sinhvien").GetAwaiter().GetResult();
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }


        public async Task<string> InsertData(Sinhvien model)
        {
            HttpClient client = new HttpClient();
            string sinhvien = JsonConvert.SerializeObject(model);
            HttpContent c = new StringContent(sinhvien, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PostAsync("https://localhost:7070/api/sinhvien", c).GetAwaiter().GetResult(); 
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }

        public async Task<string> UpdateData(Sinhvien model)
        {
            HttpClient client = new HttpClient();
            string sinhvien = JsonConvert.SerializeObject(model);
            HttpContent c = new StringContent(sinhvien, Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = client.PutAsync("https://localhost:7070/api/sinhvien/" + model.id, c).GetAwaiter().GetResult(); //check doi link api
            httpResponse.EnsureSuccessStatusCode();
            string responseString = await httpResponse.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
