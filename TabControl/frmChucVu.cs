using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.View;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                var lstCV = fn_ChucVuRespository.GetAllChucVu();
                if (lstCV != null)
                {
                    chucVuBindingSource.DataSource = lstCV;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng chức vụ" + ex.Message);
            }

        }
        private void btnThemCV_Click(object sender, EventArgs e)
        {
            frmThaoTacCV frmThemCV = new frmThaoTacCV();
            {
                var lstCV = fn_ChucVuRespository.GetAllChucVu();
                string MaMoi = lstCV.Max(cv => cv.MaCV);
                frmThemCV.MaMoi = (!string.IsNullOrEmpty(MaMoi)) ? "CV" + (int.Parse(MaMoi.Substring(2, MaMoi.Length - 2)) + 1).ToString("D2") : "CV01";
                if (frmThemCV.ShowDialog() == DialogResult.OK)
                {
                    ToastMSS ts = new ToastMSS("Thêm thành công !", "SUCCESS");
                    ts.Show();
                    LoadData();
                }
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstCV = fn_ChucVuRespository.GetAllChucVu();
                if (lstCV != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    chucVuBindingSource.DataSource = lstCV.Where(cv =>
                    cv.MaCV.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower()) ||
                     cv.TenCV.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    chucVuBindingSource.DataSource = lstCV;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng chức vụ" + ex.Message);
            }
        }
        public static ChucVu cvSua { get; set; }
        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgChucVu.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTacCV frmSuaCV = new frmThaoTacCV();
                {
                    cvSua = fn_ChucVuRespository.GetQuyenChucVu(dtgChucVu.CurrentRow.Cells["MaCV"].Value.ToString());
                    if (frmSuaCV.ShowDialog() == DialogResult.OK)
                    {
                        ToastMSS ts = new ToastMSS("Sửa thành công !", "SUCCESS");
                        ts.Show();
                        LoadData();
                    }
                }
            }
            else if (dtgChucVu.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var cv = new ChucVu();
                {
                    cv.MaCV = Convert.ToString(dtgChucVu.CurrentRow.Cells["MaCV"].Value);
                }
                MssBox mss = new MssBox("Bạn có muốn xóa mã " + cv.MaCV + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    bool result = fn_ChucVuRespository.DeleteChucVu(cv);
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

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            if (frmQLNhanVien.cv.ThaoTacChucVu == 2)
            {
                btnThemCV.Enabled = false;
                dtgChucVu.Columns["ThaoTacSua"].Visible = false;
                dtgChucVu.Columns["ThaoTacXoa"].Visible = false;
            }
            LoadData();
        }
    }
}
