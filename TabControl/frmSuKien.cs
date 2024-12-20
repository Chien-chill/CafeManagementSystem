using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmSuKien : Form
    {
        public frmSuKien()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                var lstSK = fn_SuKienRespository.GetAllSuKien();
                if (lstSK != null)
                {
                    SuKienbindingSource.DataSource = lstSK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sự kiện" + ex.Message);
            }
        }
        private void btnThemSK_Click(object sender, EventArgs e)
        {
            frmThaoTacSK frmThemSK = new frmThaoTacSK();
            {
                var lstSK = fn_SuKienRespository.GetAllSuKien();
                string MaMoi = lstSK.Max(sk => sk.MaSK);
                frmThemSK.MaMoi = (!string.IsNullOrEmpty(MaMoi)) ? "SK" + (int.Parse(MaMoi.Substring(2, MaMoi.Length - 2)) + 1).ToString("D2") : "SK01";
                if (frmThemSK.ShowDialog() == DialogResult.OK)
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
                var lstSK = fn_SuKienRespository.GetAllSuKien();
                if (lstSK != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    SuKienbindingSource.DataSource = lstSK.Where(sk =>
                    sk.MaSK.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower()) ||
                     sk.TenSK.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    SuKienbindingSource.DataSource = lstSK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sự kiện" + ex.Message);
            }
        }
        public static SuKien skSua { get; set; }
        private void dtgSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgSuKien.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTacSK frmSuaSK = new frmThaoTacSK();
                {
                    var lstSK = fn_SuKienRespository.GetAllSuKien();
                    skSua = lstSK.FirstOrDefault(sk => sk.MaSK.Equals(Convert.ToString(dtgSuKien.CurrentRow.Cells["MaSK"].Value)));
                    if (frmSuaSK.ShowDialog() == DialogResult.OK)
                    {
                        ToastMSS ts = new ToastMSS("Sửa thành công !", "SUCCESS");
                        ts.Show();
                        LoadData();
                    }
                }
            }
            else if (dtgSuKien.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var sk = new SuKien();
                {
                    sk.MaSK = Convert.ToString(dtgSuKien.CurrentRow.Cells["MaSK"].Value);
                }
                MssBox mss = new MssBox("Bạn có muốn xóa mã " + sk.MaSK + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    bool result = true;
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

        private void frmSuKien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
