using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.TabControl
{
    public partial class frmDoUong : Form
    {
        public frmDoUong()
        {
            InitializeComponent();
        }
        public void LoadDataSP()
        {
            try
            {
                var lstDU = fn_SanPhamRespository.GetDoUong();
                if (lstDU != null)
                {
                    SanPhambindingSource.DataSource = lstDU;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sản phẩm" + ex.Message);
            }
        }
        private void frmDoUong_Load(object sender, EventArgs e)
        {
            LoadDataSP();
        }

        public static SanPham DoUong { get; set; }
        public static List<string> lstSpUpdate = new List<string>();
        private void dtgDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDoUong.CurrentCell.OwningColumn.Name == "ThaoTacSua")
            {
                frmThaoTac frmSuaDU = new frmThaoTac();
                {
                    var lstDU = fn_SanPhamRespository.GetDoUong();
                    DoUong = lstDU.FirstOrDefault(sp => sp.MaSP.Equals(Convert.ToString(dtgDoUong.CurrentRow.Cells["MaDU"].Value)));
                    frmSuaDU.frmCall = "DoUong";
                    if (frmSuaDU.ShowDialog() == DialogResult.OK)
                    {
                        ToastMSS ts = new ToastMSS("Sửa thành công !", "SUCCESS");
                        ts.Show();
                        lstSpUpdate.Add(Convert.ToString(dtgDoUong.CurrentRow.Cells["MaDU"].Value));
                        LoadDataSP();
                    }
                }
            }
            else if (dtgDoUong.CurrentCell.OwningColumn.Name == "ThaoTacXoa")
            {
                var sp = new SanPham();
                {
                    sp.MaSP = Convert.ToString(dtgDoUong.CurrentRow.Cells["MaDU"].Value);
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
            else if (dtgDoUong.CurrentCell.OwningColumn.Name == "ChiTiet")
            {
                var lstDU = fn_SanPhamRespository.GetDoUong();
                DoUong = lstDU.FirstOrDefault(sp => sp.MaSP.Equals(Convert.ToString(dtgDoUong.CurrentRow.Cells["MaDU"].Value)));
                frmChiTietSP chitiet = new frmChiTietSP();
                chitiet.ShowDialog();
            }
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmThaoTac frmThemDU = new frmThaoTac();
            {
                var lstDU = fn_SanPhamRespository.GetAllSanPham();
                string MaMoi = lstDU.Max(sp => sp.MaSP);
                frmThemDU.MaMoi = (!string.IsNullOrEmpty(MaMoi)) ? "SP" + (int.Parse(MaMoi.Substring(2, MaMoi.Length - 2)) + 1).ToString("D2") : "SP01";
                frmThemDU.frmCall = "DoUong";
                if (frmThemDU.ShowDialog() == DialogResult.OK)
                {
                    ToastMSS ts = new ToastMSS("Thêm thành công !", "SUCCESS");
                    ts.Show();
                    LoadDataSP();
                }
            }
        }

        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstDU = fn_SanPhamRespository.GetDoUong();
                if (lstDU != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    SanPhambindingSource.DataSource = lstDU.Where(sp =>
                    sp.MaSP.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower()) ||
                     sp.TenSP.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    SanPhambindingSource.DataSource = lstDU;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sản phẩm" + ex.Message);
            }
        }
    }
}
