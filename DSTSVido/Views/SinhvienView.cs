using DSTSVido.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSTSVido
{
    public partial class SinhvienView : Form, ISinhvienView
    {
        public SinhvienView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        private void AssociateAndRaiseViewEvents()
        {
            //SearchSV
            //btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            
            btnImportData.Click += delegate { ImportDataEvent?.Invoke(this, EventArgs.Empty); };
            //txtSearch.KeyDown += (s, e) =>
            //{
            //    if (e.KeyCode == Keys.Enter)
            //        SearchEvent?.Invoke(this, EventArgs.Empty);
            //};


            //SearchTT
            btnSreachTT.Click += delegate { SearchEventTT?.Invoke(this, EventArgs.Empty); };
            //btnSreachTT.Click += delegate{SearchStatus?.Invoke(this, EventArgs.Empty);};
            txtSearchTT.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEventTT?.Invoke(this, EventArgs.Empty);
            };
            //Status
            //btnEditData.Click += (s, e) =>
            //{
            //    if (tcTrungTuyenDetail.TabPages.Count > 1)
            //    {
            //        tcTrungTuyenDetail.TabPages.Remove(tabPageTtDetail);
            //    }
            //    tcTrungTuyenDetail.TabPages.Add(tabPageTtDetail);
            //    EditData?.Invoke(this, EventArgs.Empty);

            //    txtTinh.Text = Convert.ToString(dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtName.Text = Convert.ToString(dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtNgay.Text = Convert.ToString(dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtThang.Text = Convert.ToString(dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtNam.Text = Convert.ToString(dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtIdNumber.Text = Convert.ToString(dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtSchool.Text = Convert.ToString(dataGridView2[7, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtClass.Text = Convert.ToString(dataGridView2[8, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtPhoneNumber.Text = Convert.ToString(dataGridView2[9, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtIdXetTuyen.Text = Convert.ToString(dataGridView2[10, dataGridView2.CurrentCell.RowIndex].Value);
            //    txtStatus.Text = Convert.ToString(dataGridView2[11, dataGridView2.CurrentCell.RowIndex].Value);
            //    cbEditTrungTuyen.Text = Convert.ToString(dataGridView2[12, dataGridView2.CurrentCell.RowIndex].Value);

            //};
            //cboxstatus.TextChanged += (s, e) =>
            //{
            //    SearchEventTT?.Invoke(this, EventArgs.Empty);
            //};

            //btnCancelEdit.Click += (s, e) =>
            //{
            //    tcTrungTuyenDetail.TabPages.Remove(tabPageTtDetail);
            //    CancelData?.Invoke(this, EventArgs.Empty);
            //};
            //btnSaveEdit.Click += (s, e) => {
            //    SaveEvent?.Invoke(this, EventArgs.Empty);
            //    if (isSuccessful)
            //    {
            //        tcTrungTuyenDetail.TabPages.Remove(tabPageTtDetail);
            //    }
            //    MessageBox.Show(Message);
            //};
        }
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_ngaysinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_hedaotao { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_nganh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_hinhthuc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_tinhtrang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_ketqua { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string sv_email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ImageName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ImageTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler SearchEventTT;
        public event EventHandler SendEvent;
        public event EventHandler ImportDataEvent;
        public event EventHandler EditData;
        public event EventHandler SaveEvent;

        public void SetSinhVienListBindingSource(BindingSource sinhvienList)
        {
            dataGridView2.DataSource = sinhvienList;
        }
    }
}
