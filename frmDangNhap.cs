using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            pnDK.Visible = false;
            pnDN.Visible = true;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            pnDK.Visible = true;
            pnDN.Visible = false;
        }

        private void btnDK1_Click(object sender, EventArgs e)
        {
            pnDK.Visible = true;
            pnDN.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnDK.Visible = false;
            pnDN.Visible = true;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            pnDK.Visible = false;
            pnDN.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tk = new TaiKhoan();
            {
                tk.Tai_Khoan = txtTKLogin.Text;
                tk.Mat_Khau = txtMKLogin.Text;
            }
            fn_TaiKhoanRespository.CheckTaiKhoan(tk);
        }
    }
}
