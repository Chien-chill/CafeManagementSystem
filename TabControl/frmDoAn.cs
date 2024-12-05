using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmDoAn : Form
    {
        public frmDoAn()
        {
            InitializeComponent();
        }
        private void frmDoAn_Load(object sender, EventArgs e)
        {
            LoadDataSP();
        }
        public void LoadDataSP()
        {
            try
            {
                var lstDA = fn_SanPhamRespository.GetDoAn();
                if (lstDA != null)
                {
                    sanPhamBindingSource.DataSource = lstDA;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sản phẩm" + ex.Message);
            }
        }
        public static SanPham DoAn { get; set; }
        private void dtgDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDoAn.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTac frmSuaDoAn = new frmThaoTac();
                {
                    var lstDA = fn_SanPhamRespository.GetDoAn();
                    DoAn = lstDA.FirstOrDefault(sp => sp.MaSP.Equals(Convert.ToString(dtgDoAn.CurrentRow.Cells["MaDA"].Value)));
                    frmSuaDoAn.frmCall = "DoAn";
                    if (frmSuaDoAn.ShowDialog() == DialogResult.OK)
                    {
                        frmDoUong.lstSpUpdate.Add(Convert.ToString(dtgDoAn.CurrentRow.Cells["MaDA"].Value));
                        LoadDataSP();
                    }
                }
            }
            else if (dtgDoAn.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var sp = new SanPham();
                {
                    sp.MaSP = Convert.ToString(dtgDoAn.CurrentRow.Cells["MaDA"].Value);
                }
                MssBox mss = new MssBox("Bạn có muốn xóa mã " + sp.MaSP + " ?");
                if (mss.ShowDialog() == DialogResult.Yes)
                {
                    bool result = fn_SanPhamRespository.DeleteSanPham(sp);
                    if (result)
                    {
                        ToastMSS ts = new ToastMSS("Xóa thành công !", "DELETE");
                        ts.Show();
                        LoadDataSP();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThaoTac frmThemDA = new frmThaoTac();
            {
                var lstDU = fn_SanPhamRespository.GetAllSanPham();
                string MaMoi = lstDU.Max(sp => sp.MaSP);
                frmThemDA.MaMoi = "SP" + (int.Parse(MaMoi.Substring(2, MaMoi.Length - 2)) + 1).ToString("D2");
                frmThemDA.frmCall = "DoAn";
                if (frmThemDA.ShowDialog() == DialogResult.OK)
                {
                    LoadDataSP();
                }
            }

        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstDA = fn_SanPhamRespository.GetDoAn();
                if (lstDA != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    sanPhamBindingSource.DataSource = lstDA.Where(sp =>
                    sp.MaSP.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower()) ||
                     sp.TenSP.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    sanPhamBindingSource.DataSource = lstDA;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sản phẩm" + ex.Message);
            }
        }
    }
}
