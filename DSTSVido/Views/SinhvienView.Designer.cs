using DSTSVido._Repositories;
using DSTSVido.Dtos;
using Newtonsoft.Json;

namespace DSTSVido
{
    partial class SinhvienView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageSvTrungTuyen = new System.Windows.Forms.TabPage();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnImportData = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSreachTT = new System.Windows.Forms.Button();
            this.txtSearchTT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tcTrungTuyenDetail = new System.Windows.Forms.TabControl();
            this.tabPageSvDetail = new System.Windows.Forms.TabPage();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.txtSv_hedaotao = new System.Windows.Forms.TextBox();
            this.txtSv_ketqua = new System.Windows.Forms.TextBox();
            this.txtSv_hinhthuc = new System.Windows.Forms.TextBox();
            this.txtSv_tinhtrang = new System.Windows.Forms.TextBox();
            this.txtSv_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSv_nganh = new System.Windows.Forms.TextBox();
            this.txtSv_ngaysinh = new System.Windows.Forms.TextBox();
            this.txtSv_name = new System.Windows.Forms.TextBox();
            this.txtSv_id = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDiemdanh = new System.Windows.Forms.TabPage();
            this.cboxKhoahoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchdd = new System.Windows.Forms.Button();
            this.cboxnguoitao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxmonhoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboxlop = new System.Windows.Forms.ComboBox();
            this.btnExportData = new System.Windows.Forms.Button();
            this.gvDiemdanh = new System.Windows.Forms.DataGridView();
            this.tabPageSvTrungTuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tcTrungTuyenDetail.SuspendLayout();
            this.tabPageSvDetail.SuspendLayout();
            this.tbDiemdanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemdanh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageSvTrungTuyen
            // 
            this.tabPageSvTrungTuyen.Controls.Add(this.btnEditData);
            this.tabPageSvTrungTuyen.Controls.Add(this.btnImportData);
            this.tabPageSvTrungTuyen.Controls.Add(this.dataGridView2);
            this.tabPageSvTrungTuyen.Controls.Add(this.btnSreachTT);
            this.tabPageSvTrungTuyen.Controls.Add(this.txtSearchTT);
            this.tabPageSvTrungTuyen.Controls.Add(this.label13);
            this.tabPageSvTrungTuyen.Location = new System.Drawing.Point(4, 38);
            this.tabPageSvTrungTuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSvTrungTuyen.Name = "tabPageSvTrungTuyen";
            this.tabPageSvTrungTuyen.Size = new System.Drawing.Size(1818, 894);
            this.tabPageSvTrungTuyen.TabIndex = 2;
            this.tabPageSvTrungTuyen.Text = "Data Xet Tuyen";
            this.tabPageSvTrungTuyen.UseVisualStyleBackColor = true;
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.Location = new System.Drawing.Point(1488, 184);
            this.btnEditData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(159, 49);
            this.btnEditData.TabIndex = 8;
            this.btnEditData.Text = "Edit";
            this.btnEditData.UseVisualStyleBackColor = true;
            // 
            // btnImportData
            // 
            this.btnImportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportData.Location = new System.Drawing.Point(1488, 125);
            this.btnImportData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(159, 49);
            this.btnImportData.TabIndex = 8;
            this.btnImportData.Text = "ImportData";
            this.btnImportData.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(63, 125);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1417, 737);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnSreachTT
            // 
            this.btnSreachTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSreachTT.Location = new System.Drawing.Point(618, 48);
            this.btnSreachTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSreachTT.Name = "btnSreachTT";
            this.btnSreachTT.Size = new System.Drawing.Size(158, 49);
            this.btnSreachTT.TabIndex = 4;
            this.btnSreachTT.Text = "Search";
            this.btnSreachTT.UseVisualStyleBackColor = true;
            // 
            // txtSearchTT
            // 
            this.txtSearchTT.Location = new System.Drawing.Point(63, 55);
            this.txtSearchTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchTT.Name = "txtSearchTT";
            this.txtSearchTT.Size = new System.Drawing.Size(547, 35);
            this.txtSearchTT.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "Search";
            // 
            // tcTrungTuyenDetail
            // 
            this.tcTrungTuyenDetail.Controls.Add(this.tabPageSvTrungTuyen);
            this.tcTrungTuyenDetail.Controls.Add(this.tabPageSvDetail);
            this.tcTrungTuyenDetail.Controls.Add(this.tbDiemdanh);
            this.tcTrungTuyenDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTrungTuyenDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTrungTuyenDetail.Location = new System.Drawing.Point(0, 0);
            this.tcTrungTuyenDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcTrungTuyenDetail.Name = "tcTrungTuyenDetail";
            this.tcTrungTuyenDetail.SelectedIndex = 0;
            this.tcTrungTuyenDetail.Size = new System.Drawing.Size(1826, 936);
            this.tcTrungTuyenDetail.TabIndex = 3;
            // 
            // tabPageSvDetail
            // 
            this.tabPageSvDetail.Controls.Add(this.btnCancelEdit);
            this.tabPageSvDetail.Controls.Add(this.btnSaveEdit);
            this.tabPageSvDetail.Controls.Add(this.txtSv_hedaotao);
            this.tabPageSvDetail.Controls.Add(this.txtSv_ketqua);
            this.tabPageSvDetail.Controls.Add(this.txtSv_hinhthuc);
            this.tabPageSvDetail.Controls.Add(this.txtSv_tinhtrang);
            this.tabPageSvDetail.Controls.Add(this.txtSv_email);
            this.tabPageSvDetail.Controls.Add(this.label8);
            this.tabPageSvDetail.Controls.Add(this.label7);
            this.tabPageSvDetail.Controls.Add(this.label6);
            this.tabPageSvDetail.Controls.Add(this.label5);
            this.tabPageSvDetail.Controls.Add(this.label2);
            this.tabPageSvDetail.Controls.Add(this.txtSv_nganh);
            this.tabPageSvDetail.Controls.Add(this.txtSv_ngaysinh);
            this.tabPageSvDetail.Controls.Add(this.txtSv_name);
            this.tabPageSvDetail.Controls.Add(this.txtSv_id);
            this.tabPageSvDetail.Controls.Add(this.label26);
            this.tabPageSvDetail.Controls.Add(this.label16);
            this.tabPageSvDetail.Controls.Add(this.label20);
            this.tabPageSvDetail.Controls.Add(this.label15);
            this.tabPageSvDetail.Location = new System.Drawing.Point(4, 38);
            this.tabPageSvDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSvDetail.Name = "tabPageSvDetail";
            this.tabPageSvDetail.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSvDetail.Size = new System.Drawing.Size(1818, 894);
            this.tabPageSvDetail.TabIndex = 3;
            this.tabPageSvDetail.Text = "SVDetail";
            this.tabPageSvDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(536, 371);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(112, 48);
            this.btnCancelEdit.TabIndex = 42;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(358, 371);
            this.btnSaveEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(112, 48);
            this.btnSaveEdit.TabIndex = 41;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            // 
            // txtSv_hedaotao
            // 
            this.txtSv_hedaotao.Location = new System.Drawing.Point(148, 289);
            this.txtSv_hedaotao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_hedaotao.Name = "txtSv_hedaotao";
            this.txtSv_hedaotao.Size = new System.Drawing.Size(320, 35);
            this.txtSv_hedaotao.TabIndex = 40;
            // 
            // txtSv_ketqua
            // 
            this.txtSv_ketqua.Location = new System.Drawing.Point(680, 40);
            this.txtSv_ketqua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_ketqua.Name = "txtSv_ketqua";
            this.txtSv_ketqua.Size = new System.Drawing.Size(320, 35);
            this.txtSv_ketqua.TabIndex = 39;
            // 
            // txtSv_hinhthuc
            // 
            this.txtSv_hinhthuc.Location = new System.Drawing.Point(680, 98);
            this.txtSv_hinhthuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_hinhthuc.Name = "txtSv_hinhthuc";
            this.txtSv_hinhthuc.Size = new System.Drawing.Size(320, 35);
            this.txtSv_hinhthuc.TabIndex = 38;
            // 
            // txtSv_tinhtrang
            // 
            this.txtSv_tinhtrang.Location = new System.Drawing.Point(680, 158);
            this.txtSv_tinhtrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_tinhtrang.Name = "txtSv_tinhtrang";
            this.txtSv_tinhtrang.Size = new System.Drawing.Size(320, 35);
            this.txtSv_tinhtrang.TabIndex = 37;
            // 
            // txtSv_email
            // 
            this.txtSv_email.Location = new System.Drawing.Point(680, 231);
            this.txtSv_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_email.Name = "txtSv_email";
            this.txtSv_email.Size = new System.Drawing.Size(320, 35);
            this.txtSv_email.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kết quả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hình thức";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(534, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hệ đào tạo";
            // 
            // txtSv_nganh
            // 
            this.txtSv_nganh.Location = new System.Drawing.Point(148, 222);
            this.txtSv_nganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_nganh.Name = "txtSv_nganh";
            this.txtSv_nganh.Size = new System.Drawing.Size(320, 35);
            this.txtSv_nganh.TabIndex = 26;
            // 
            // txtSv_ngaysinh
            // 
            this.txtSv_ngaysinh.Location = new System.Drawing.Point(148, 145);
            this.txtSv_ngaysinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_ngaysinh.Name = "txtSv_ngaysinh";
            this.txtSv_ngaysinh.Size = new System.Drawing.Size(320, 35);
            this.txtSv_ngaysinh.TabIndex = 23;
            // 
            // txtSv_name
            // 
            this.txtSv_name.Location = new System.Drawing.Point(148, 85);
            this.txtSv_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_name.Name = "txtSv_name";
            this.txtSv_name.Size = new System.Drawing.Size(320, 35);
            this.txtSv_name.TabIndex = 22;
            // 
            // txtSv_id
            // 
            this.txtSv_id.Location = new System.Drawing.Point(148, 31);
            this.txtSv_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSv_id.Name = "txtSv_id";
            this.txtSv_id.Size = new System.Drawing.Size(320, 35);
            this.txtSv_id.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 222);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 29);
            this.label26.TabIndex = 12;
            this.label26.Text = "Ngành";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 149);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 29);
            this.label16.TabIndex = 7;
            this.label16.Text = "Ngày sinh";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 89);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 29);
            this.label20.TabIndex = 6;
            this.label20.Text = "Họ và tên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 29);
            this.label15.TabIndex = 1;
            this.label15.Text = "sv_id";
            // 
            // tbDiemdanh
            // 
            this.tbDiemdanh.Controls.Add(this.cboxKhoahoc);
            this.tbDiemdanh.Controls.Add(this.label4);
            this.tbDiemdanh.Controls.Add(this.btnSearchdd);
            this.tbDiemdanh.Controls.Add(this.cboxnguoitao);
            this.tbDiemdanh.Controls.Add(this.label3);
            this.tbDiemdanh.Controls.Add(this.cboxmonhoc);
            this.tbDiemdanh.Controls.Add(this.label1);
            this.tbDiemdanh.Controls.Add(this.label14);
            this.tbDiemdanh.Controls.Add(this.cboxlop);
            this.tbDiemdanh.Controls.Add(this.btnExportData);
            this.tbDiemdanh.Controls.Add(this.gvDiemdanh);
            this.tbDiemdanh.Location = new System.Drawing.Point(4, 38);
            this.tbDiemdanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiemdanh.Name = "tbDiemdanh";
            this.tbDiemdanh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDiemdanh.Size = new System.Drawing.Size(1818, 894);
            this.tbDiemdanh.TabIndex = 4;
            this.tbDiemdanh.Text = "Diem danh";
            this.tbDiemdanh.UseVisualStyleBackColor = true;
            // 
            // cboxKhoahoc
            // 
            this.cboxKhoahoc.FormattingEnabled = true;
            this.cboxKhoahoc.Items.AddRange(new object[] {
            "13"});
            this.cboxKhoahoc.Location = new System.Drawing.Point(1222, 88);
            this.cboxKhoahoc.Name = "cboxKhoahoc";
            this.cboxKhoahoc.Size = new System.Drawing.Size(169, 37);
            this.cboxKhoahoc.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1098, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Khóa học";
            // 
            // btnSearchdd
            // 
            this.btnSearchdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchdd.Location = new System.Drawing.Point(1616, 147);
            this.btnSearchdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchdd.Name = "btnSearchdd";
            this.btnSearchdd.Size = new System.Drawing.Size(158, 49);
            this.btnSearchdd.TabIndex = 16;
            this.btnSearchdd.Text = "Search";
            this.btnSearchdd.UseVisualStyleBackColor = true;
            // 
            // cboxnguoitao
            // 
            this.cboxnguoitao.FormattingEnabled = true;
            this.cboxnguoitao.Items.AddRange(new object[] {
            "ctphu"});
            this.cboxnguoitao.Location = new System.Drawing.Point(1222, 25);
            this.cboxnguoitao.Name = "cboxnguoitao";
            this.cboxnguoitao.Size = new System.Drawing.Size(169, 37);
            this.cboxnguoitao.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1098, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Người tạo";
            // 
            // cboxmonhoc
            // 
            this.cboxmonhoc.FormattingEnabled = true;
            this.cboxmonhoc.Location = new System.Drawing.Point(146, 88);
            this.cboxmonhoc.Name = "cboxmonhoc";
            this.cboxmonhoc.Size = new System.Drawing.Size(750, 37);
            this.cboxmonhoc.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Môn học";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 29);
            this.label14.TabIndex = 11;
            this.label14.Text = "Lớp";
            // 
            // cboxlop
            // 
            this.cboxlop.FormattingEnabled = true;
            this.cboxlop.Location = new System.Drawing.Point(146, 22);
            this.cboxlop.Name = "cboxlop";
            this.cboxlop.Size = new System.Drawing.Size(750, 37);
            this.cboxlop.TabIndex = 10;
            // 
            // btnExportData
            // 
            this.btnExportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportData.Location = new System.Drawing.Point(1615, 299);
            this.btnExportData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(159, 49);
            this.btnExportData.TabIndex = 9;
            this.btnExportData.Text = "ExportData";
            this.btnExportData.UseVisualStyleBackColor = true;
            // 
            // gvDiemdanh
            // 
            this.gvDiemdanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDiemdanh.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gvDiemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDiemdanh.Location = new System.Drawing.Point(30, 147);
            this.gvDiemdanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gvDiemdanh.Name = "gvDiemdanh";
            this.gvDiemdanh.RowHeadersWidth = 51;
            this.gvDiemdanh.Size = new System.Drawing.Size(1540, 728);
            this.gvDiemdanh.TabIndex = 6;
            // 
            // SinhvienView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 936);
            this.Controls.Add(this.tcTrungTuyenDetail);
            this.Name = "SinhvienView";
            this.Text = "Form1";
            this.tabPageSvTrungTuyen.ResumeLayout(false);
            this.tabPageSvTrungTuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tcTrungTuyenDetail.ResumeLayout(false);
            this.tabPageSvDetail.ResumeLayout(false);
            this.tabPageSvDetail.PerformLayout();
            this.tbDiemdanh.ResumeLayout(false);
            this.tbDiemdanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiemdanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSvTrungTuyen;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSreachTT;
        private System.Windows.Forms.TextBox txtSearchTT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tcTrungTuyenDetail;
        private System.Windows.Forms.TabPage tabPageSvDetail;
        private System.Windows.Forms.TextBox txtSv_nganh;
        private System.Windows.Forms.TextBox txtSv_ngaysinh;
        private System.Windows.Forms.TextBox txtSv_name;
        private System.Windows.Forms.TextBox txtSv_id;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSv_hedaotao;
        private System.Windows.Forms.TextBox txtSv_ketqua;
        private System.Windows.Forms.TextBox txtSv_hinhthuc;
        private System.Windows.Forms.TextBox txtSv_tinhtrang;
        private System.Windows.Forms.TextBox txtSv_email;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TabPage tbDiemdanh;
        private System.Windows.Forms.DataGridView gvDiemdanh;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.ComboBox cboxnguoitao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxmonhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboxlop;
        private System.Windows.Forms.Button btnSearchdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxKhoahoc;
    }
}

