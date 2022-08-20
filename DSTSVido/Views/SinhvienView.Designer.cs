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
            this.tabPageSvTrungTuyen.Location = new System.Drawing.Point(4, 29);
            this.tabPageSvTrungTuyen.Name = "tabPageSvTrungTuyen";
            this.tabPageSvTrungTuyen.Size = new System.Drawing.Size(1015, 547);
            this.tabPageSvTrungTuyen.TabIndex = 2;
            this.tabPageSvTrungTuyen.Text = "Data Xet Tuyen";
            this.tabPageSvTrungTuyen.UseVisualStyleBackColor = true;
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.Location = new System.Drawing.Point(688, 120);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(106, 32);
            this.btnEditData.TabIndex = 8;
            this.btnEditData.Text = "Edit";
            this.btnEditData.UseVisualStyleBackColor = true;
            // 
            // btnImportData
            // 
            this.btnImportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportData.Location = new System.Drawing.Point(688, 81);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(106, 32);
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
            this.dataGridView2.Location = new System.Drawing.Point(42, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(641, 358);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnSreachTT
            // 
            this.btnSreachTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSreachTT.Location = new System.Drawing.Point(423, 36);
            this.btnSreachTT.Name = "btnSreachTT";
            this.btnSreachTT.Size = new System.Drawing.Size(105, 32);
            this.btnSreachTT.TabIndex = 4;
            this.btnSreachTT.Text = "Search";
            this.btnSreachTT.UseVisualStyleBackColor = true;
            // 
            // txtSearchTT
            // 
            this.txtSearchTT.Location = new System.Drawing.Point(42, 36);
            this.txtSearchTT.Name = "txtSearchTT";
            this.txtSearchTT.Size = new System.Drawing.Size(366, 26);
            this.txtSearchTT.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
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
            this.tcTrungTuyenDetail.Name = "tcTrungTuyenDetail";
            this.tcTrungTuyenDetail.SelectedIndex = 0;
            this.tcTrungTuyenDetail.Size = new System.Drawing.Size(1023, 580);
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
            this.tabPageSvDetail.Location = new System.Drawing.Point(4, 29);
            this.tabPageSvDetail.Name = "tabPageSvDetail";
            this.tabPageSvDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSvDetail.Size = new System.Drawing.Size(1015, 547);
            this.tabPageSvDetail.TabIndex = 3;
            this.tabPageSvDetail.Text = "SVDetail";
            this.tabPageSvDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(357, 241);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 31);
            this.btnCancelEdit.TabIndex = 42;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(239, 241);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(75, 31);
            this.btnSaveEdit.TabIndex = 41;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            // 
            // txtSv_hedaotao
            // 
            this.txtSv_hedaotao.Location = new System.Drawing.Point(99, 188);
            this.txtSv_hedaotao.Name = "txtSv_hedaotao";
            this.txtSv_hedaotao.Size = new System.Drawing.Size(215, 26);
            this.txtSv_hedaotao.TabIndex = 40;
            // 
            // txtSv_ketqua
            // 
            this.txtSv_ketqua.Location = new System.Drawing.Point(453, 26);
            this.txtSv_ketqua.Name = "txtSv_ketqua";
            this.txtSv_ketqua.Size = new System.Drawing.Size(215, 26);
            this.txtSv_ketqua.TabIndex = 39;
            // 
            // txtSv_hinhthuc
            // 
            this.txtSv_hinhthuc.Location = new System.Drawing.Point(453, 64);
            this.txtSv_hinhthuc.Name = "txtSv_hinhthuc";
            this.txtSv_hinhthuc.Size = new System.Drawing.Size(215, 26);
            this.txtSv_hinhthuc.TabIndex = 38;
            // 
            // txtSv_tinhtrang
            // 
            this.txtSv_tinhtrang.Location = new System.Drawing.Point(453, 103);
            this.txtSv_tinhtrang.Name = "txtSv_tinhtrang";
            this.txtSv_tinhtrang.Size = new System.Drawing.Size(215, 26);
            this.txtSv_tinhtrang.TabIndex = 37;
            // 
            // txtSv_email
            // 
            this.txtSv_email.Location = new System.Drawing.Point(453, 150);
            this.txtSv_email.Name = "txtSv_email";
            this.txtSv_email.Size = new System.Drawing.Size(215, 26);
            this.txtSv_email.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kết quả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hình thức";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Hệ đào tạo";
            // 
            // txtSv_nganh
            // 
            this.txtSv_nganh.Location = new System.Drawing.Point(99, 144);
            this.txtSv_nganh.Name = "txtSv_nganh";
            this.txtSv_nganh.Size = new System.Drawing.Size(215, 26);
            this.txtSv_nganh.TabIndex = 26;
            // 
            // txtSv_ngaysinh
            // 
            this.txtSv_ngaysinh.Location = new System.Drawing.Point(99, 94);
            this.txtSv_ngaysinh.Name = "txtSv_ngaysinh";
            this.txtSv_ngaysinh.Size = new System.Drawing.Size(215, 26);
            this.txtSv_ngaysinh.TabIndex = 23;
            // 
            // txtSv_name
            // 
            this.txtSv_name.Location = new System.Drawing.Point(99, 55);
            this.txtSv_name.Name = "txtSv_name";
            this.txtSv_name.Size = new System.Drawing.Size(215, 26);
            this.txtSv_name.TabIndex = 22;
            // 
            // txtSv_id
            // 
            this.txtSv_id.Location = new System.Drawing.Point(99, 20);
            this.txtSv_id.Name = "txtSv_id";
            this.txtSv_id.Size = new System.Drawing.Size(215, 26);
            this.txtSv_id.TabIndex = 13;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 144);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 20);
            this.label26.TabIndex = 12;
            this.label26.Text = "Ngành";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Ngày sinh";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "Họ và tên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
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
            this.tbDiemdanh.Location = new System.Drawing.Point(4, 29);
            this.tbDiemdanh.Name = "tbDiemdanh";
            this.tbDiemdanh.Padding = new System.Windows.Forms.Padding(3);
            this.tbDiemdanh.Size = new System.Drawing.Size(1015, 547);
            this.tbDiemdanh.TabIndex = 4;
            this.tbDiemdanh.Text = "Diem danh";
            this.tbDiemdanh.UseVisualStyleBackColor = true;
            // 
            // cboxKhoahoc
            // 
            this.cboxKhoahoc.FormattingEnabled = true;
            this.cboxKhoahoc.Items.AddRange(new object[] {
            "13"});
            this.cboxKhoahoc.Location = new System.Drawing.Point(815, 57);
            this.cboxKhoahoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboxKhoahoc.Name = "cboxKhoahoc";
            this.cboxKhoahoc.Size = new System.Drawing.Size(114, 28);
            this.cboxKhoahoc.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Khóa học";
            // 
            // btnSearchdd
            // 
            this.btnSearchdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchdd.Location = new System.Drawing.Point(870, 96);
            this.btnSearchdd.Name = "btnSearchdd";
            this.btnSearchdd.Size = new System.Drawing.Size(105, 32);
            this.btnSearchdd.TabIndex = 16;
            this.btnSearchdd.Text = "Search";
            this.btnSearchdd.UseVisualStyleBackColor = true;
            // 
            // cboxnguoitao
            // 
            this.cboxnguoitao.FormattingEnabled = true;
            this.cboxnguoitao.Items.AddRange(new object[] {
            "ctphu"});
            this.cboxnguoitao.Location = new System.Drawing.Point(815, 16);
            this.cboxnguoitao.Margin = new System.Windows.Forms.Padding(2);
            this.cboxnguoitao.Name = "cboxnguoitao";
            this.cboxnguoitao.Size = new System.Drawing.Size(114, 28);
            this.cboxnguoitao.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Người tạo";
            // 
            // cboxmonhoc
            // 
            this.cboxmonhoc.FormattingEnabled = true;
            this.cboxmonhoc.Location = new System.Drawing.Point(97, 57);
            this.cboxmonhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboxmonhoc.Name = "cboxmonhoc";
            this.cboxmonhoc.Size = new System.Drawing.Size(501, 28);
            this.cboxmonhoc.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Môn học";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Lớp";
            // 
            // cboxlop
            // 
            this.cboxlop.FormattingEnabled = true;
            this.cboxlop.Location = new System.Drawing.Point(97, 14);
            this.cboxlop.Margin = new System.Windows.Forms.Padding(2);
            this.cboxlop.Name = "cboxlop";
            this.cboxlop.Size = new System.Drawing.Size(501, 28);
            this.cboxlop.TabIndex = 10;
            // 
            // btnExportData
            // 
            this.btnExportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportData.Location = new System.Drawing.Point(870, 149);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(106, 32);
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
            this.gvDiemdanh.Location = new System.Drawing.Point(20, 96);
            this.gvDiemdanh.Name = "gvDiemdanh";
            this.gvDiemdanh.RowHeadersWidth = 51;
            this.gvDiemdanh.Size = new System.Drawing.Size(830, 400);
            this.gvDiemdanh.TabIndex = 6;
            // 
            // SinhvienView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 580);
            this.Controls.Add(this.tcTrungTuyenDetail);
            this.Margin = new System.Windows.Forms.Padding(2);
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

