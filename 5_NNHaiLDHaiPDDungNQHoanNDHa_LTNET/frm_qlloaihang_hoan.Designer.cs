﻿namespace QLBHTH_PhanDinhDung
{
    partial class frm_qlloaihang_hoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mahang_hoan = new System.Windows.Forms.TextBox();
            this.txt_tenhang_hoan = new System.Windows.Forms.TextBox();
            this.btn_them_hoan = new System.Windows.Forms.Button();
            this.btn_xoa_hoan = new System.Windows.Forms.Button();
            this.btn_sua_hoan = new System.Windows.Forms.Button();
            this.btn_nhaplai_hoan = new System.Windows.Forms.Button();
            this.dgv_loaihang_hoan = new System.Windows.Forms.DataGridView();
            this.btn_quaylai_hoan = new System.Windows.Forms.Button();
            this.mlh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaihang_hoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LOẠI HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Loại";
            // 
            // txt_mahang_hoan
            // 
            this.txt_mahang_hoan.Location = new System.Drawing.Point(166, 92);
            this.txt_mahang_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mahang_hoan.Name = "txt_mahang_hoan";
            this.txt_mahang_hoan.Size = new System.Drawing.Size(355, 20);
            this.txt_mahang_hoan.TabIndex = 1;
            // 
            // txt_tenhang_hoan
            // 
            this.txt_tenhang_hoan.Location = new System.Drawing.Point(166, 136);
            this.txt_tenhang_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenhang_hoan.Name = "txt_tenhang_hoan";
            this.txt_tenhang_hoan.Size = new System.Drawing.Size(355, 20);
            this.txt_tenhang_hoan.TabIndex = 1;
            // 
            // btn_them_hoan
            // 
            this.btn_them_hoan.Location = new System.Drawing.Point(123, 196);
            this.btn_them_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_hoan.Name = "btn_them_hoan";
            this.btn_them_hoan.Size = new System.Drawing.Size(65, 23);
            this.btn_them_hoan.TabIndex = 2;
            this.btn_them_hoan.Text = "Thêm";
            this.btn_them_hoan.UseVisualStyleBackColor = true;
            this.btn_them_hoan.Click += new System.EventHandler(this.btn_them_hoan_Click);
            // 
            // btn_xoa_hoan
            // 
            this.btn_xoa_hoan.Location = new System.Drawing.Point(345, 196);
            this.btn_xoa_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_hoan.Name = "btn_xoa_hoan";
            this.btn_xoa_hoan.Size = new System.Drawing.Size(65, 23);
            this.btn_xoa_hoan.TabIndex = 2;
            this.btn_xoa_hoan.Text = "Xoá";
            this.btn_xoa_hoan.UseVisualStyleBackColor = true;
            this.btn_xoa_hoan.Click += new System.EventHandler(this.btn_xoa_hoan_Click);
            // 
            // btn_sua_hoan
            // 
            this.btn_sua_hoan.Location = new System.Drawing.Point(234, 196);
            this.btn_sua_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sua_hoan.Name = "btn_sua_hoan";
            this.btn_sua_hoan.Size = new System.Drawing.Size(65, 23);
            this.btn_sua_hoan.TabIndex = 2;
            this.btn_sua_hoan.Text = "Sửa";
            this.btn_sua_hoan.UseVisualStyleBackColor = true;
            this.btn_sua_hoan.Click += new System.EventHandler(this.btn_sua_hoan_Click);
            // 
            // btn_nhaplai_hoan
            // 
            this.btn_nhaplai_hoan.Location = new System.Drawing.Point(456, 196);
            this.btn_nhaplai_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nhaplai_hoan.Name = "btn_nhaplai_hoan";
            this.btn_nhaplai_hoan.Size = new System.Drawing.Size(65, 23);
            this.btn_nhaplai_hoan.TabIndex = 2;
            this.btn_nhaplai_hoan.Text = "Nhập Lại";
            this.btn_nhaplai_hoan.UseVisualStyleBackColor = true;
            this.btn_nhaplai_hoan.Click += new System.EventHandler(this.btn_nhaplai_hoan_Click);
            // 
            // dgv_loaihang_hoan
            // 
            this.dgv_loaihang_hoan.AllowUserToAddRows = false;
            this.dgv_loaihang_hoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaihang_hoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_loaihang_hoan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_loaihang_hoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaihang_hoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mlh,
            this.tenloai});
            this.dgv_loaihang_hoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_loaihang_hoan.Location = new System.Drawing.Point(0, 274);
            this.dgv_loaihang_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_loaihang_hoan.Name = "dgv_loaihang_hoan";
            this.dgv_loaihang_hoan.RowHeadersWidth = 51;
            this.dgv_loaihang_hoan.RowTemplate.Height = 24;
            this.dgv_loaihang_hoan.Size = new System.Drawing.Size(717, 168);
            this.dgv_loaihang_hoan.TabIndex = 3;
            this.dgv_loaihang_hoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaihang_hoan_CellClick);
            // 
            // btn_quaylai_hoan
            // 
            this.btn_quaylai_hoan.Location = new System.Drawing.Point(567, 196);
            this.btn_quaylai_hoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quaylai_hoan.Name = "btn_quaylai_hoan";
            this.btn_quaylai_hoan.Size = new System.Drawing.Size(65, 23);
            this.btn_quaylai_hoan.TabIndex = 2;
            this.btn_quaylai_hoan.Text = "Quay Lại";
            this.btn_quaylai_hoan.UseVisualStyleBackColor = true;
            this.btn_quaylai_hoan.Click += new System.EventHandler(this.btn_quaylai_hoan_Click);
            // 
            // mlh
            // 
            this.mlh.DataPropertyName = "Maloai";
            this.mlh.HeaderText = "Mã loại hàng";
            this.mlh.Name = "mlh";
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "Tenloai";
            this.tenloai.HeaderText = "Tên loại hàng";
            this.tenloai.Name = "tenloai";
            // 
            // frm_qlloaihang_hoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 442);
            this.Controls.Add(this.dgv_loaihang_hoan);
            this.Controls.Add(this.btn_sua_hoan);
            this.Controls.Add(this.btn_quaylai_hoan);
            this.Controls.Add(this.btn_nhaplai_hoan);
            this.Controls.Add(this.btn_xoa_hoan);
            this.Controls.Add(this.btn_them_hoan);
            this.Controls.Add(this.txt_tenhang_hoan);
            this.Controls.Add(this.txt_mahang_hoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_qlloaihang_hoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Quản Lý Loại Hàng Hoàn";
            this.Load += new System.EventHandler(this.frm_qlloaihang_hoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaihang_hoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mahang_hoan;
        private System.Windows.Forms.TextBox txt_tenhang_hoan;
        private System.Windows.Forms.Button btn_them_hoan;
        private System.Windows.Forms.Button btn_xoa_hoan;
        private System.Windows.Forms.Button btn_sua_hoan;
        private System.Windows.Forms.Button btn_nhaplai_hoan;
        private System.Windows.Forms.DataGridView dgv_loaihang_hoan;
        private System.Windows.Forms.Button btn_quaylai_hoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
    }
}