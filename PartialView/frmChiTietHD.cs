using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmChiTietHD : Form
    {
        public frmChiTietHD()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                var lstSP = fn_HoaDonRespository.GetChiTietHDTheoMa(frmDSHoaDon.MaChiTietHD);
                ChiTietHDbindingSource.DataSource = lstSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sản phẩm" + ex.Message);
            }
        }
        private void frmChiTietHD_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
