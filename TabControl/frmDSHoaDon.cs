using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmDSHoaDon : Form
    {
        public frmDSHoaDon()
        {
            InitializeComponent();
        }
        public void LoadData(string TrangThai)
        {
            try
            {
                var lstHD = fn_HoaDonRespository.GetHoaDonTheoTrangThai(TrangThai);
                if (lstHD != null)
                {
                    HoaDonbindingSource.DataSource = lstHD;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng hóa đơn" + ex.Message);
            }
        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            LoadData("Tất Cả");
        }
        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTrangThai.Text)
            {
                case "Chưa Xác Nhận":
                    LoadData(cbTrangThai.Text);
                    break;
                case "Hoàn Thành":
                    LoadData(cbTrangThai.Text);
                    break;
                case "Đã Hủy":
                    LoadData(cbTrangThai.Text);
                    break;
                default:
                    LoadData("Tất Cả");
                    break;
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstHD = fn_HoaDonRespository.GetHoaDonTheoTrangThai(cbTrangThai.Text);
                if (lstHD != null)
                {
                    HoaDonbindingSource.DataSource = lstHD.Where(hd => hd.MaHD.Contains(txtTimKiem.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng hóa đơn" + ex.Message);
            }
        }
    }
}
