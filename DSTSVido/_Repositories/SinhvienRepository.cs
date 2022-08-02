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
        public SinhvienRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<Sinhvien> GetAll()
        {
            var trungtuyenList = new List<Sinhvien>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select [id]
                                              ,[sv_id]
                                              ,[sv_name]
                                              ,[sv_ngaysinh]
                                              ,[sv_nganh]
                                              ,[sv_hedaotao]
                                              ,[sv_ketqua]
                                              ,[sv_hinhthuc]
                                              ,[sv_tinhtrang]
                                              ,[sv_email]
                                              ,[img_name]
                                              ,[img_time]
                                        FROM[Vido].[dbo].[tb_sinhvien]";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sinhvienModel = new Sinhvien();
                        sinhvienModel.id = (int)reader[0];
                        sinhvienModel.sv_id = reader[1].ToString();
                        sinhvienModel.sv_name = reader[2].ToString();
                        sinhvienModel.sv_ngaysinh = reader[3].ToString();
                        sinhvienModel.sv_nganh = reader[4].ToString();
                        sinhvienModel.sv_hedaotao = reader[5].ToString();
                        sinhvienModel.sv_ketqua = reader[6].ToString();
                        sinhvienModel.sv_hinhthuc = reader[7].ToString();
                        sinhvienModel.sv_tinhtrang = reader[8].ToString();
                        sinhvienModel.sv_mail = reader[9].ToString();
                        trungtuyenList.Add(sinhvienModel);
                    }
                }
            }
            return trungtuyenList;
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
    }
}
