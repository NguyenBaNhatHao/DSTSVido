﻿namespace DSTSVido
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
            this.tabPageSvTrungTuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tcTrungTuyenDetail.SuspendLayout();
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
            this.tabPageSvTrungTuyen.Size = new System.Drawing.Size(905, 454);
            this.tabPageSvTrungTuyen.TabIndex = 2;
            this.tabPageSvTrungTuyen.Text = "Data Xet Tuyen";
            this.tabPageSvTrungTuyen.UseVisualStyleBackColor = true;
            // 
            // btnEditData
            // 
            this.btnEditData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditData.Location = new System.Drawing.Point(779, 125);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(106, 32);
            this.btnEditData.TabIndex = 8;
            this.btnEditData.Text = "Edit";
            this.btnEditData.UseVisualStyleBackColor = true;
            // 
            // btnImportData
            // 
            this.btnImportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportData.Location = new System.Drawing.Point(779, 86);
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
            this.dataGridView2.Size = new System.Drawing.Size(722, 352);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnSreachTT
            // 
            this.btnSreachTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSreachTT.Location = new System.Drawing.Point(229, 33);
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
            this.txtSearchTT.Size = new System.Drawing.Size(177, 26);
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
            this.tcTrungTuyenDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTrungTuyenDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTrungTuyenDetail.Location = new System.Drawing.Point(0, 0);
            this.tcTrungTuyenDetail.Name = "tcTrungTuyenDetail";
            this.tcTrungTuyenDetail.SelectedIndex = 0;
            this.tcTrungTuyenDetail.Size = new System.Drawing.Size(913, 487);
            this.tcTrungTuyenDetail.TabIndex = 3;
            // 
            // SinhvienView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.tcTrungTuyenDetail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SinhvienView";
            this.Text = "Form1";
            this.tabPageSvTrungTuyen.ResumeLayout(false);
            this.tabPageSvTrungTuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tcTrungTuyenDetail.ResumeLayout(false);
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
    }
}

