using DSTSVido.Views;
using DSTSVido.Models;
using DSTSVido._Repositories;
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
            tcTrungTuyenDetail.TabPages.Remove(tabPageSvDetail);
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
            btnEditData.Click += (s, e) =>
            {
                tcTrungTuyenDetail.TabPages.Add(tabPageSvDetail);
                //EditData?.Invoke(this, EventArgs.Empty);

                txtSv_id.Text = Convert.ToString(dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_name.Text = Convert.ToString(dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_ngaysinh.Text = Convert.ToString(dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_nganh.Text = Convert.ToString(dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_hedaotao.Text = Convert.ToString(dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_ketqua.Text = Convert.ToString(dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_hinhthuc.Text = Convert.ToString(dataGridView2[7, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_tinhtrang.Text = Convert.ToString(dataGridView2[8, dataGridView2.CurrentCell.RowIndex].Value);
                txtSv_email.Text = Convert.ToString(dataGridView2[9, dataGridView2.CurrentCell.RowIndex].Value);
                
            };
            //cboxstatus.TextChanged += (s, e) =>
            //{
            //    SearchEventTT?.Invoke(this, EventArgs.Empty);
            //};

            btnCancelEdit.Click += (s, e) =>
            {
                tcTrungTuyenDetail.TabPages.Remove(tabPageSvDetail);
                CancelData?.Invoke(this, EventArgs.Empty);
            };
            btnSaveEdit.Click += (s, e) =>
            {
                if (string.IsNullOrEmpty(txtSv_id.Text) || string.IsNullOrEmpty(txtSv_name.Text) || string.IsNullOrEmpty(txtSv_ngaysinh.Text) || 
                 string.IsNullOrEmpty(txtSv_nganh.Text) || string.IsNullOrEmpty(txtSv_hedaotao.Text) || 
                string.IsNullOrEmpty(txtSv_ketqua.Text) || string.IsNullOrEmpty(txtSv_hinhthuc.Text) || string.IsNullOrEmpty(txtSv_tinhtrang.Text) || string.IsNullOrEmpty(txtSv_email.Text))
                {
                    MessageBox.Show("Xin hãy nhập đủ dữ liệu");
                }
                else
                {
                    dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value = txtSv_id.Text;
                    dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value = txtSv_name.Text;
                    dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value = txtSv_ngaysinh.Text;
                    dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value = txtSv_nganh.Text;
                    dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value = txtSv_hedaotao.Text;
                    dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value = txtSv_ketqua.Text;
                    dataGridView2[7, dataGridView2.CurrentCell.RowIndex].Value = txtSv_hinhthuc.Text;
                    dataGridView2[8, dataGridView2.CurrentCell.RowIndex].Value = txtSv_tinhtrang.Text;
                    dataGridView2[9, dataGridView2.CurrentCell.RowIndex].Value = txtSv_email.Text;
                    Sinhvien model = new Sinhvien();
                    model.id = (int)dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value;
                    model.sv_id = txtSv_id.Text;
                    model.sv_name = txtSv_name.Text;
                    model.sv_ngaysinh = txtSv_ngaysinh.Text;
                    model.sv_nganh = txtSv_nganh.Text;
                    model.sv_hedaotao = txtSv_hedaotao.Text;
                    model.sv_ketqua = txtSv_ketqua.Text;
                    model.sv_hinhthuc = txtSv_hinhthuc.Text;
                    model.sv_tinhtrang = txtSv_tinhtrang.Text;
                    model.sv_email = txtSv_email.Text;
                    SinhvienRepository repository = new SinhvienRepository();
                    repository.UpdateData(model);
                    dataGridView2.Update();
                    tcTrungTuyenDetail.TabPages.Remove(tabPageSvDetail);
                    UpdateEditData?.Invoke(this, EventArgs.Empty);
                }
            };
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
        public event EventHandler CancelData;
        public event EventHandler SaveData;
        public event EventHandler UpdateEditData;

        public void SetSinhVienListBindingSource(BindingSource sinhvienList)
        {
            dataGridView2.DataSource = sinhvienList;
        }
    }
}
