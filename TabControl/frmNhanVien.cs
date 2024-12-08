using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThaoTacNV frmThemNV = new frmThaoTacNV();
            {
                var lstNV = fn_NhanVienRespository.GetAllNhanVien();
                string MaMoi = lstNV.Max(nv => nv.MaNV);
                frmThemNV.MaMoi = (!string.IsNullOrEmpty(MaMoi)) ? "NV" + (int.Parse(MaMoi.Substring(2, MaMoi.Length - 2)) + 1).ToString("D2") : "NV01";
                if (frmThemNV.ShowDialog() == DialogResult.OK)
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
                var lstNV = fn_NhanVienRespository.GetAllNhanVien();
                if (lstNV != null)
                {
                    NhanVienbindingSource.DataSource = lstNV;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng nhân viên" + ex.Message);
            }

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public static NhanVien nvSua { get; set; }
        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgNhanVien.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTacNV frmSuaNV = new frmThaoTacNV();
                {
                    var lstNV = fn_NhanVienRespository.GetAllNhanVien();
                    nvSua = lstNV.FirstOrDefault(nv => nv.MaNV.Equals(Convert.ToString(dtgNhanVien.CurrentRow.Cells["MaNV"].Value)));
                    if (frmSuaNV.ShowDialog() == DialogResult.OK)
                    {
                        ToastMSS ts = new ToastMSS("Sửa thành công !", "SUCCESS");
                        ts.Show();
                        LoadData();
                    }
                }
            }
            else if (dtgNhanVien.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var nv = new NhanVien();
                {
                    nv.MaNV = Convert.ToString(dtgNhanVien.CurrentRow.Cells["MaNV"].Value);
                }
                MssBox mss = new MssBox("Bạn có muốn xóa mã " + nv.MaNV + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    bool result = fn_NhanVienRespository.DeleteNV(nv);
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

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstNV = fn_NhanVienRespository.GetAllNhanVien();
                if (lstNV != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    NhanVienbindingSource.DataSource = lstNV.Where(nv =>
                    nv.MaNV.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower()) ||
                     nv.TenNV.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    NhanVienbindingSource.DataSource = lstNV;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng nhân viên" + ex.Message);
            }
        }
    }
}
