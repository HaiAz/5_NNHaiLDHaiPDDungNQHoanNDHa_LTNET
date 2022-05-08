﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHTH_PhanDinhDung
{
    public partial class frm_giaodienchinh_ha : Form
    {
        public frm_giaodienchinh_ha()
        {
            InitializeComponent();
        }

        private void btn_gttv_ha_Click(object sender, EventArgs e)
        {
            frm_gttv_ha gttv = new frm_gttv_ha();
            this.Hide();
            gttv.ShowDialog();
        }

        private void frm_giaodienchinh_ha_Load(object sender, EventArgs e)
        {
            if(Program.role == false)
            {
                btn_qldoanhthu_ha.Enabled = false;
                btn_qlnhanvien_ha.Enabled=false;
            }
            qlbh_dungDataContext qlbh = new qlbh_dungDataContext();
            var nhanvien = qlbh.Nhanviens.Select(nv => new { nv.TenNV, nv.MaNV }).Where(nv => nv.MaNV == Program.mnv).SingleOrDefault();
            if(nhanvien != null)
            {
                lb_tennv_ha.Text = $"Xin chào! {nhanvien.TenNV}";
            }

        }

        private void frm_giaodienchinh_ha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangxuat_ha_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dangnhap_dung dangnhap = new frm_dangnhap_dung();
            dangnhap.ShowDialog();
        }
    }
}
