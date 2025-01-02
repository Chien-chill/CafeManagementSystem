using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmThaoTacTK : Form
    {
        public frmThaoTacTK()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!txtMatKhau.Equals(txtReMatKhau.Text))
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Hai mật khẩu không trùng khớp");
                }
                else
                {
                    TaiKhoan tk = new TaiKhoan();
                    {
                        tk.Tai_Khoan = txtTaiKhoan.Text;
                        tk.Mat_Khau = txtMatKhau.Text;
                        tk.Ma_NV = cbNhanVien.SelectedValue.ToString();
                    }
                    if (!TaiKhoan.KiemTraTK(tk, out string errorMessage))
                    {
                        Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        Mss.Show($"Thêm thất bại: \n{errorMessage}");
                    }
                    else
                    {
                        bool result = fn_TaiKhoanRespository.AddTaiKhoan(tk);
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

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!txtMatKhau.Equals(txtReMatKhau.Text))
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Hai mật khẩu không trùng khớp");
                }
                else
                {
                    TaiKhoan tk = new TaiKhoan();
                    {
                        tk.Tai_Khoan = txtTaiKhoan.Text;
                        tk.Mat_Khau = txtMatKhau.Text;
                        tk.Ma_NV = cbNhanVien.SelectedValue.ToString();
                    }
                    if (!TaiKhoan.KiemTraTK(tk, out string errorMessage))
                    {
                        Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                        Mss.Show($"Thêm thất bại: \n{errorMessage}");
                    }
                    else
                    {
                        bool result = fn_TaiKhoanRespository.UpdateTaiKhoan(tk);
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

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Sửa: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            frmTaiKhoan.tkSua = null;
            this.Close();
        }

        private void frmThaoTacTK_Load(object sender, EventArgs e)
        {
            try
            {
                var lstNV = fn_NhanVienRespository.GetAllNhanVien();
                nhanVienBindingSource.DataSource = lstNV;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi load combox nhân viên: " + ex.Message);
            }
            txtTaiKhoan.ReadOnly = false;
            btnThem.Visible = true;
            btnSua.Visible = false;
            if (frmTaiKhoan.tkSua != null)
            {
                txtTaiKhoan.ReadOnly = true;
                lblTieuDe.Text = "SỬA TÀI KHOẢN";
                btnThem.Visible = false;
                btnSua.Visible = true;
                txtTaiKhoan.Text = frmTaiKhoan.tkSua.Tai_Khoan;
                cbNhanVien.SelectedValue = frmTaiKhoan.tkSua.Ma_NV;
            }
        }
    }
}
