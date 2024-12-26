using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using Phan_Mem_Quan_Ly.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            frmSuKien.skSua = null;
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenSK.Text))
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Thêm thất bại: \n - Tên sự kiện không được để trống");
                }
                else
                {
                    List<ChiTietSuKien> lstskDetails = new List<ChiTietSuKien>();
                    foreach (var i in flpGiamGia.Controls.OfType<DiscountControl>())
                    {
                        ChiTietSuKien chiTietSuKien = new ChiTietSuKien();
                        {
                            chiTietSuKien.Ma_SP = i.MaSP;
                            chiTietSuKien.Giam_Gia = Convert.ToInt16(i.GiamGia);
                        }
                        lstskDetails.Add(chiTietSuKien);
                    }

                    SuKien sk = new SuKien();
                    {
                        sk.TenSK = txtTenSK.Text;
                        sk.TrangThai = (toggleBatTat.Checked) ? "Đang Kích Hoạt" : "Chờ Kích Hoạt";

                    }
                    bool result = fn_SuKienRespository.AddSuKien(sk, lstskDetails);
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenSK.Text))
                {
                    Mss.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    Mss.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    Mss.Show($"Thêm thất bại: \n - Tên sự kiện không được để trống");
                }
                else
                {
                    List<ChiTietSuKien> lstskDetails = new List<ChiTietSuKien>();
                    foreach (var i in flpGiamGia.Controls.OfType<DiscountControl>())
                    {
                        ChiTietSuKien chiTietSuKien = new ChiTietSuKien();
                        {
                            chiTietSuKien.Ma_SP = i.MaSP;
                            chiTietSuKien.Giam_Gia = Convert.ToInt16(i.GiamGia);
                        }
                        lstskDetails.Add(chiTietSuKien);
                    }

                    SuKien sk = new SuKien();
                    {
                        sk.MaSK = txtMaSK.Text;
                        sk.TenSK = txtTenSK.Text;
                        sk.TrangThai = (toggleBatTat.Checked) ? "Đang Kích Hoạt" : "Chờ Kích Hoạt";

                    }
                    bool result = fn_SuKienRespository.UPDSuKien(sk, lstskDetails);
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void frmThaoTacSK_Load(object sender, EventArgs e)
        {
            LoadData();
            if (frmSuKien.skSua != null)
            {
                txtMaSK.Text = frmSuKien.skSua.MaSK;
                txtTenSK.Text = frmSuKien.skSua.TenSK;
                if (frmSuKien.skSua.TrangThai.Equals("Đang Kích Hoạt"))
                {
                    toggleBatTat.Checked = true;
                    lblKichHoat.Text = "ON";
                    lblKichHoat.ForeColor = Color.SeaGreen;
                }
                else
                {
                    toggleBatTat.Checked = false;
                    lblKichHoat.Text = "OFF";
                    lblKichHoat.ForeColor = Color.Crimson;
                }
                try
                {
                    var lstGiamGia = fn_SuKienRespository.GetChiTietSKTheoMa(txtMaSK.Text);
                    // Duyệt những mã sản phẩm đã được giảm giá của dtgSanPham
                    foreach (DataGridViewRow row in dtgSanPham.Rows)
                    {
                        string MaSProw = Convert.ToString(row.Cells["MaSP"].Value);
                        if (lstGiamGia.Any(item => item.Ma_SP.Equals(MaSProw)))
                        {
                            row.Cells["GiamGia"].Value = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi :" + ex.Message);
                }
            }
            else
            {
                btnThem.Visible = true;
                btnSua.Visible = false;
            }
        }

        public void LoadData()
        {
            try
            {
                var lstSP = fn_SanPhamRespository.GetAllSanPham();
                if (lstSP != null)
                {
                    SanPhambindingSource.DataSource = lstSP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng nhân viên" + ex.Message);
            }
        }

        private void dtgSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgSanPham.Columns[e.ColumnIndex].Name == "GiamGia")
            {
                bool isChecked = Convert.ToBoolean(dtgSanPham.Rows[e.RowIndex].Cells["GiamGia"].Value);
                string maSP = Convert.ToString(dtgSanPham.Rows[e.RowIndex].Cells["MaSP"].Value);
                if (isChecked)
                {
                    // Thêm DiscountControl vào FlowLayoutPanel
                    DiscountControl discount = new DiscountControl();
                    discount.MaSP = maSP;
                    flpGiamGia.Controls.Add(discount);
                }
                else
                {
                    // Xóa DiscountControl khỏi FlowLayoutPanel
                    var discountControl = flpGiamGia.Controls.OfType<DiscountControl>()
                        .FirstOrDefault(dis => dis.MaSP.Equals(maSP));
                    if (discountControl != null)
                    {
                        flpGiamGia.Controls.Remove(discountControl);
                    }
                }
            }
        }
        private void dtgSanPham_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgSanPham.IsCurrentCellDirty)
            {
                // Cập nhật ngay lập tức giá trị ô checkbox
                dtgSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void txtTimKiem_IconRightClick(object sender, EventArgs e)
        {
            try
            {
                var lstSP = fn_SanPhamRespository.GetDoAn();
                if (lstSP != null && !string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    SanPhambindingSource.DataSource = lstSP.Where(sp =>
                    sp.MaSP.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower()) ||
                     sp.TenSP.Trim().ToLower().Contains(
                    txtTimKiem.Text.Trim().ToLower())).ToList();

                }
                else if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    SanPhambindingSource.DataSource = lstSP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không load được bảng sản phẩm" + ex.Message);
            }
        }

        private void toggleBatTat_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleBatTat.Checked)
            {
                lblKichHoat.Text = "ON";
                lblKichHoat.ForeColor = Color.SeaGreen;
            }
            else
            {
                lblKichHoat.Text = "OFF";
                lblKichHoat.ForeColor = Color.Crimson;
            }
        }
    }
}
