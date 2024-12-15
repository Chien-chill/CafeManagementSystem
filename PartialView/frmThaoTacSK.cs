using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.UserControls;
using System;
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
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SuKien sk = new SuKien();
                {
                    sk.TenSK = txtTenSK.Text;
                    sk.ThoiGianBD = dtpThoiGianBD.Value;
                    sk.ThoiGianKT = dtpThoiGianKT.Value;
                }
                bool result = true;
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void frmThaoTacSK_Load(object sender, EventArgs e)
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
    }
}
