using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DSTSVido.Models
{
    public class Sinhvien
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string sv_id { get; set; }
        public string sv_name { get; set; }
        public string sv_ngaysinh { get; set; }
        public string sv_nganh { get; set; }
        public string sv_hedaotao { get; set; }
        public string sv_ketqua { get; set; }
        public string sv_hinhthuc { get; set; }
        public string sv_tinhtrang { get; set; }
        public string sv_email { get ; set; }
        public string img_name { get; set; }
        public DateTime img_time { get; set; }
        //[DisplayName("Id")]
        //public int Id { get => id; set => id = value; }

        //[DisplayName("Sinh viên Id")]
        //[Required(ErrorMessage = "Sinh viên id không được để trống")]
        //[StringLength(40, ErrorMessage = "Sinh viên Id không được vượt quá 40 ký tự")]
        //public string Sv_id { get => sv_id; set => sv_id = value; }

        //[DisplayName("Tên sinh viên")]
        //[StringLength(255, ErrorMessage = "Tên sinh viên không được vượt quá 255 ký tự")]
        //public string Sv_name { get => sv_name; set => sv_name = value; }

        //[DisplayName("Ngày sinh")]
        //[StringLength(10, ErrorMessage = "Ngày sinh không được vượt quá 10 ký tự")]
        //public string Sv_ngaysinh { get => sv_ngaysinh; set => sv_ngaysinh = value; }

        //[DisplayName("Ngành")]
        //[StringLength(255, ErrorMessage = "Ngành không được vượt quá 255 ký tự")]
        //public string Sv_nganh { get => sv_nganh; set => sv_nganh = value; }

        //[DisplayName("Hệ đào tạo")]
        //[Required(ErrorMessage = "Hệ đào tạo không được để trống")]
        //[StringLength(255, ErrorMessage = "Hệ đào tạo không được vượt quá 255 ký tự")]
        //public string Sv_hedaotao { get => sv_hedaotao; set => sv_hedaotao = value; }

        //[DisplayName("Kết quả")]
        //[Required(ErrorMessage = "Kết quả không được để trống")]
        //[StringLength(255, ErrorMessage = "Kết quả không được vượt quá 255 ký tự")]
        //public string Sv_ketqua { get => sv_ketqua; set => sv_ketqua = value; }

        //[DisplayName("Hình thức")]
        //[Required(ErrorMessage = "Hình thức không được để trống")]
        //[StringLength(200, ErrorMessage = "Hình thức không được vượt quá 200 ký tự")]
        //public string Sv_hinhthuc { get => sv_hinhthuc; set => sv_hinhthuc = value; }

        //[DisplayName("Tình trạng")]
        //[StringLength(20, ErrorMessage = "Tình trạng không được vượt quá 20 ký tự")]
        //public string Sv_tinhtrang { get => sv_tinhtrang; set => sv_tinhtrang = value; }

        //[DisplayName("Tên hình ảnh")]
        //[StringLength(255, ErrorMessage = "Tên hình ảnh không được vượt quá 255 ký tự")]
        //public string Img_name { get => img_name; set => img_name = value; }

        //[DisplayName("Image Time")]
        //public DateTime Img_time { get => img_time; set => img_time = value; }

        //[DisplayName("Mail")]
        //[StringLength(255, ErrorMessage = "Mail không được vượt quá 255 ký tự")]
        //public string Sv_mail { get => sv_mail; set => sv_mail = value; }
    }
}
