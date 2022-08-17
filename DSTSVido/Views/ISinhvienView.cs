using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSTSVido.Views
{
    public interface ISinhvienView
    {
        string Id { get; set; }
        string sv_id { get; set; }
        string sv_name { get; set; }
        string sv_ngaysinh { get; set; }
        string sv_hedaotao { get; set; }
        string sv_nganh { get; set; }
        string sv_hinhthuc { get; set; }
        string sv_tinhtrang { get; set; }
        string sv_ketqua { get; set; }
        string sv_email { get; set; }
        string ImageName { get; set; }
        string ImageTime { get; set; }

        string SearchValue { get; set; }
        
        string Lop { get; set; }
        string Monhoc { get; set; }
        string Nguoitao { get; set; }
        string Khoahoc { get; set; }
        //bool IsEdit { get; set; }
        //bool IsSucessful { get; set; }
        //string Message { get; set; }

        //string SearchTTValue { get; set; }

        event EventHandler SearchEvent;
        event EventHandler SearchEventTT;
        //event EventHandler SearchStatus;
        event EventHandler SendEvent;
        event EventHandler ImportDataEvent;
        event EventHandler EditData;
        event EventHandler SaveEvent;
        event EventHandler UpdateEditData;
        event EventHandler ExportExcel;
        event EventHandler Searchdd;
        void SetSinhVienListBindingSource(BindingSource sinhvienList);
        void SetDiemDanhListBindingSource(BindingSource diemdanhlist);
        /*    void SetTrungTuyenlistBindingSource(BindingSource trungtuyenlist);*/
        void Show();
    }
}
