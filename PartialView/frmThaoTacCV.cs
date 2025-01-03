﻿using Guna.UI2.WinForms;
using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmThaoTacCV : Form
    {
        public frmThaoTacCV()
        {
            InitializeComponent();
        }
        public string MaMoi { get => txtMaCV.Text; set => txtMaCV.Text = value; }
        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmChucVu.cvSua = null;
        }
        private int XetQuyen(Guna2Button KoCapQuyen, Guna2Button ChiXem, Guna2Button CapQuyen)
        {
            if (KoCapQuyen.Checked)
            {
                return 1;
            }
            else if (ChiXem.Checked)
            {
                return 2;
            }
            else if (CapQuyen.Checked)
            {
                return 3;
            }
            return 0;
        }
        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenCV.Text))
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Thêm thất bại: \n - Tên chức vụ không được để trống");
                }
                else
                {
                    ChucVu cv = new ChucVu();
                    {
                        cv.TenCV = txtTenCV.Text;
                        cv.ThaoTacNhanVien = XetQuyen(btnNV1, btnNV2, btnNV3);
                        cv.ThaoTacSanPham = XetQuyen(btnSP1, btnSP2, btnSP3);
                        cv.ThaoTacThongKe = XetQuyen(btnTK1, btnTK2, btnTK3);
                        cv.ThaoTacSuKien = XetQuyen(btnSK1, btnSK2, btnSK3);
                        cv.ThaoTacDonHang = XetQuyen(btnHD1, btnHD2, btnHD3);
                        cv.ThaoTacKhachHang = XetQuyen(btnKH1, btnKH2, btnKH3);
                        cv.ThaoTacChucVu = XetQuyen(btnCV1, btnCV2, btnCV3);
                    }
                    bool result = fn_ChucVuRespository.AddChucVu(cv);
                    if (result)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        Mss.Show("Thêm thất bại ở SQL");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenCV.Text))
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Thêm thất bại: \n - Tên chức vụ không được để trống");
                }
                else
                {
                    ChucVu cv = new ChucVu();
                    {
                        cv.MaCV = txtMaCV.Text;
                        cv.TenCV = txtTenCV.Text;
                        cv.ThaoTacNhanVien = XetQuyen(btnNV1, btnNV2, btnNV3);
                        cv.ThaoTacSanPham = XetQuyen(btnSP1, btnSP2, btnSP3);
                        cv.ThaoTacThongKe = XetQuyen(btnTK1, btnTK2, btnTK3);
                        cv.ThaoTacSuKien = XetQuyen(btnSK1, btnSK2, btnSK3);
                        cv.ThaoTacDonHang = XetQuyen(btnHD1, btnHD2, btnHD3);
                        cv.ThaoTacKhachHang = XetQuyen(btnKH1, btnKH2, btnKH3);
                        cv.ThaoTacChucVu = XetQuyen(btnCV1, btnCV2, btnCV3);
                    }
                    bool result = fn_ChucVuRespository.UpdateChucVu(cv);
                    if (result)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        Mss.Show("Thêm thất bại ở SQL");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }
        private void LoadDefault()
        {
            btnSP1.Checked = true;
            btnCV1.Checked = true;
            btnKH1.Checked = true;
            btnNV1.Checked = true;
            btnTK1.Checked = true;
            btnSK1.Checked = true;
            btnHD1.Checked = true;
            if (frmChucVu.cvSua != null)
            {
                btnSP1.Checked = false;
                btnCV1.Checked = false;
                btnKH1.Checked = false;
                btnNV1.Checked = false;
                btnTK1.Checked = false;
                btnSK1.Checked = false;
                btnHD1.Checked = false;
            }
        }
        private void CheckQuyen(int level, Guna2Button KoCapQuyen, Guna2Button ChiXem, Guna2Button CapQuyen)
        {
            switch (level)
            {
                case 1:
                    KoCapQuyen.Checked = true;
                    break;
                case 2:
                    ChiXem.Checked = true;
                    break;
                case 3:
                    CapQuyen.Checked = true;
                    break;
            }
        }
        private void frmThaoTacCV_Load(object sender, System.EventArgs e)
        {
            LoadDefault();
            btnThem.Visible = true;
            btnSua.Visible = false;
            if (frmChucVu.cvSua != null)
            {

                lblTieuDe.Text = "SỬA CHỨC VỤ";
                btnThem.Visible = false;
                btnSua.Visible = true;
                txtMaCV.Text = frmChucVu.cvSua.MaCV;
                txtTenCV.Text = frmChucVu.cvSua.TenCV;
                CheckQuyen(frmChucVu.cvSua.ThaoTacSanPham, btnSP1, btnSP2, btnSP3);
                CheckQuyen(frmChucVu.cvSua.ThaoTacChucVu, btnCV1, btnCV2, btnCV3);
                CheckQuyen(frmChucVu.cvSua.ThaoTacDonHang, btnHD1, btnHD2, btnHD3);
                CheckQuyen(frmChucVu.cvSua.ThaoTacKhachHang, btnKH1, btnKH2, btnKH3);
                CheckQuyen(frmChucVu.cvSua.ThaoTacThongKe, btnTK1, btnTK2, btnTK3);
                CheckQuyen(frmChucVu.cvSua.ThaoTacNhanVien, btnNV1, btnNV2, btnNV3);
                CheckQuyen(frmChucVu.cvSua.ThaoTacSuKien, btnSK1, btnSK2, btnSK3);
            }
        }


    }
}
