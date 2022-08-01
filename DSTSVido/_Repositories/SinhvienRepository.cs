using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DSTSVido.Models;

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


        public void InsertData(Sinhvien model)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                /*DECLARE @RC int
                DECLARE @Tinh nvarchar(100)
                DECLARE @HoTen nvarchar(max)
                DECLARE @NgaySinh tinyint
                DECLARE @ThangSinh tinyint
                DECLARE @NamSinh int
                DECLARE @IDNumber varchar(50)
                DECLARE @Truong nvarchar(max)
                DECLARE @Lop nvarchar(50)
                DECLARE @SoDienThoai varchar(20)
                */
                connection.Open();
                command.Connection = connection;
                command.CommandText = "[dbo].[InsertStudent]";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@sv_id", SqlDbType.NVarChar).Value = model.sv_id;
                command.Parameters.Add("@sv_name", SqlDbType.NVarChar).Value = model.sv_name;
                command.Parameters.Add("@sv_ngaysinh", SqlDbType.NVarChar).Value = model.sv_ngaysinh;
                command.Parameters.Add("@sv_nganh", SqlDbType.NVarChar).Value = model.sv_nganh;
                command.Parameters.Add("@sv_hedaotao", SqlDbType.NVarChar).Value = model.sv_hedaotao;
                command.Parameters.Add("@sv_ketqua", SqlDbType.NVarChar).Value = model.sv_ketqua;
                command.Parameters.Add("@sv_hinhthuc", SqlDbType.NVarChar).Value = model.sv_hinhthuc;
                command.Parameters.Add("@sv_tinhtrang", SqlDbType.NVarChar).Value = model.sv_tinhtrang;
                if(model.sv_mail == null)
                {
                    model.sv_mail = DBNull.Value.ToString();
                    command.Parameters.Add("@sv_email", SqlDbType.NVarChar).Value = model.sv_mail;
                }
                else
                {
                    command.Parameters.Add("@sv_email", SqlDbType.NVarChar).Value = model.sv_mail;
                }
                command.ExecuteNonQuery();
            }
        }
    }
}
