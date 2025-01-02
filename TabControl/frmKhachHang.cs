using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            if (frmQLKhachHang.cv.ThaoTacKhachHang == 2)
            {
                btnThemKH.Enabled = false;
                dtgKhachHang.Columns["ThaoTacSua"].Visible = false;
                dtgKhachHang.Columns["ThaoTacXoa"].Visible = false;
            }
            LoadData();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThaoTacKH frmThemKH = new frmThaoTacKH();
            {
                var lstKH = fn_KhachHangRespository.GetAllKhachHang();
                string MaMoi = lstKH.Max(kh => kh.MaKH);
                frmThemKH.MaMoi = (!string.IsNullOrEmpty(MaMoi)) ? "KH" + (int.Parse(MaMoi.Substring(2, MaMoi.Length - 2)) + 1).ToString("D2") : "KH01";
                if (frmThemKH.ShowDialog() == DialogResult.OK)
                {
                    ToastMSS ts = new ToastMSS("Thêm thành công !", "SUCCESS");
                    ts.Show();
                    LoadData();
                }
            }
        }
        private void LoadData()
        {
            try
            {
                var lstKH = fn_KhachHangRespository.GetAllKhachHang();
                if (lstKH != null)
                {
                    KhachHangbindingSource.DataSource = lstKH;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng khách hàng" + ex.Message);
            }

        }
        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstKH = fn_KhachHangRespository.GetAllKhachHang();
                if (lstKH != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    KhachHangbindingSource.DataSource = lstKH.Where(kh =>
                     kh.MaKH.Trim().ToLower().Contains(
                     txtTimKiem.Text.Trim().ToLower()) ||
                      kh.TenKH.Trim().ToLower().Contains(
                     txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    KhachHangbindingSource.DataSource = lstKH;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng khách hàng" + ex.Message);
            }
        }
        public static KhachHang khSua { get; set; }
        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgKhachHang.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTacKH frmSuaKH = new frmThaoTacKH();
                {
                    var lstKH = fn_KhachHangRespository.GetAllKhachHang();
                    khSua = lstKH.FirstOrDefault(kh => kh.MaKH.Equals(Convert.ToString(dtgKhachHang.CurrentRow.Cells["MaKH"].Value)));
                    if (frmSuaKH.ShowDialog() == DialogResult.OK)
                    {
                        ToastMSS ts = new ToastMSS("Sửa thành công !", "SUCCESS");
                        ts.Show();
                        LoadData();
                    }
                }
            }
            else if (dtgKhachHang.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var kh = new KhachHang();
                {
                    kh.MaKH = Convert.ToString(dtgKhachHang.CurrentRow.Cells["MaKH"].Value);
                }
                MssBox mss = new MssBox("Bạn có muốn xóa mã " + kh.MaKH + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    bool result = fn_KhachHangRespository.DeleteKH(kh);
                    if (result)
                    {
                        ToastMSS ts = new ToastMSS("Xóa thành công !", "DELETE");
                        ts.Show();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }
    }
}
