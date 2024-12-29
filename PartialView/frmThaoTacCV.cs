using Guna.UI2.WinForms;
using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
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

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
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
                    }
                    ChiTietChucVu ctcv = new ChiTietChucVu();
                    {
                        ctcv.ThaoTacNhanVien = XetQuyen(btnNV1, btnNV2, btnNV3);
                        ctcv.ThaoTacSanPham = XetQuyen(btnSP1, btnSP2, btnSP3);
                        ctcv.ThaoTacThongKe = XetQuyen(btnTK1, btnTK2, btnTK3);
                        ctcv.ThaoTacSuKien = XetQuyen(btnSK1, btnSK2, btnSK3);
                        ctcv.ThaoTacDonHang = XetQuyen(btnHD1, btnHD2, btnHD3);
                        ctcv.ThaoTacKhachHang = XetQuyen(btnKH1, btnKH2, btnKH3);
                        ctcv.ThaoTacChucVu = XetQuyen(btnCV1, btnCV2, btnCV3);
                    }
                    bool result = fn_ChucVuRespository.AddChucVu(cv, ctcv);
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
        }
        private void frmThaoTacCV_Load(object sender, System.EventArgs e)
        {
            LoadDefault();
        }


    }
}
