using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                var lstTK = fn_TaiKhoanRespository.GetAllTaiKhoan();
                if (lstTK != null)
                {
                    taiKhoanBindingSource.DataSource = lstTK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng tài khoản" + ex.Message);
            }
        }
        private void btnThemTK_Click(object sender, System.EventArgs e)
        {
            frmThaoTacTK frmThemTK = new frmThaoTacTK();
            {
                if (frmThemTK.ShowDialog() == DialogResult.OK)
                {
                    ToastMSS ts = new ToastMSS("Thêm thành công !", "SUCCESS");
                    ts.Show();
                    LoadData();
                }
            }
        }
        public static TaiKhoan tkSua { get; set; }
        private void dtgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgTaiKhoan.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTacTK frmSuaTK = new frmThaoTacTK();
                {
                    var lstTK = fn_TaiKhoanRespository.GetAllTaiKhoan();
                    tkSua = lstTK.FirstOrDefault(tk => tk.Tai_Khoan.Equals(Convert.ToString(dtgTaiKhoan.CurrentRow.Cells["TaiKhoan"].Value)));
                    if (frmSuaTK.ShowDialog() == DialogResult.OK)
                    {
                        ToastMSS ts = new ToastMSS("Sửa thành công !", "SUCCESS");
                        ts.Show();
                        LoadData();
                    }
                }
            }
            else if (dtgTaiKhoan.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var tk = new TaiKhoan();
                {
                    tk.Tai_Khoan = Convert.ToString(dtgTaiKhoan.CurrentRow.Cells["TaiKhoan"].Value);
                }
                MssBox mss = new MssBox("Bạn có muốn xóa mã " + tk.Tai_Khoan + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    bool result = fn_TaiKhoanRespository.DeleteTaiKhoan(tk);
                    if (result)
                    {
                        ToastMSS ts = new ToastMSS("Xóa thành công !", "DELETE");
                        ts.Show();
                        LoadData();
                    }
                    else
                    {
                        ToastMSS ts = new ToastMSS("Xóa thất bại !", "INFO");
                        ts.Show();
                    }
                }
            }
        }

        private void txtTimKiem_IconRightClick(object sender, System.EventArgs e)
        {
            try
            {
                var lstTK = fn_TaiKhoanRespository.GetAllTaiKhoan();
                if (lstTK != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    taiKhoanBindingSource.DataSource = lstTK.Where(tk =>
                    tk.Tai_Khoan.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    taiKhoanBindingSource.DataSource = lstTK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sự kiện" + ex.Message);
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            if (frmQLNhanVien.cv.ThaoTacChucVu == 2)
            {
                btnThemTK.Enabled = false;
                dtgTaiKhoan.Columns["ThaoTacSua"].Visible = false;
                dtgTaiKhoan.Columns["ThaoTacXoa"].Visible = false;
            }
            LoadData();
        }
    }
}
