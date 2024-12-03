﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.View;
using System.Security.Cryptography;
using Phan_Mem_Quan_Ly.PartialView;
namespace Phan_Mem_Quan_Ly
{
    public partial class frmTrangChu : Form
    {
        public static frmTrangChu Instance;
        public frmTrangChu()
        {
            Instance = this;
            InitializeComponent();
        }
        private Dictionary<string, Form> frmDic = new Dictionary<string, Form>();
        private void loadfrm(string formName, Form f)
        {
            foreach (Control c in this.MainPanel.Controls)
            {
                if (c is Form)
                {
                    c.Hide();
                }
            }
            if (!frmDic.ContainsKey(formName))
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.MainPanel.Controls.Add(f);
                frmDic[formName] = f;
            }

            Form frm = frmDic[formName];
            frm.Show();
            if (formName == "BanHang" && frm is frmBanHang banHang)
            {
                txtTimKiem.IconRightClick += (sender, e) =>
                {
                    banHang.TimKiemSP(txtTimKiem.Text);
                };
                txtTimKiem.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        banHang.TimKiemSP(txtTimKiem.Text);
                    }
                };
                txtTimKiem.TextChanged += (sender, e) =>
                {
                    if (string.IsNullOrEmpty(txtTimKiem.Text))
                        banHang.TimKiemSP(txtTimKiem.Text);
                };
                banHang.btnThanhToan.Click += (sender, e) =>
                {
                    if(banHang.checkHD)
                    {
                        frmTrangChu_Load(sender, e);
                    }
                };
                banHang.loadDanhMuc();
            }
            
            this.MainPanel.Tag = frm;
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            btnTatCa_Click(sender, e);
            loadThongBao();
        }
        public void loadThongBao()
        {
            var lstHDChuaXuLy = fn_HoaDonRespository.GetHDChuaXuLy();
            if (lstHDChuaXuLy.Any())
            {
                notifPDonHang.Visible = true;
                notifPDonHang.Text = lstHDChuaXuLy.Count.ToString("D2");
            }
            else
            {
                notifPDonHang.Visible = false;
            }
        }
        private void btnTatCa_Click(object sender, EventArgs e)
        {
            loadfrm("BanHang", new frmBanHang());

        }

        private void btnNuocUong_Click(object sender, EventArgs e)
        {
            loadfrm("NhapSP", new frmNhapSP());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            loadfrm("DonHang", new frmDonHang());
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
        }
    }
}
