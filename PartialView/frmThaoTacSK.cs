using Phan_Mem_Quan_Ly.Model;
using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmThaoTacSK : Form
    {
        public frmThaoTacSK()
        {
            InitializeComponent();
        }
        public string MaMoi { get => txtMaSK.Text; set => txtMaSK.Text = value; }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SuKien sk = new SuKien();
                {
                    sk.TenSK = txtTenSK.Text;
                    sk.ThoiGianBD = dtpThoiGianBD.Value;
                    sk.ThoiGianKT = dtpThoiGianKT.Value;
                }
                bool result = true;
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void frmThaoTacSK_Load(object sender, EventArgs e)
        {

        }
    }
}
