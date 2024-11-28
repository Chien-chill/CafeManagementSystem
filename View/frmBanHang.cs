using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.View
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        public void AddSanPham(SanPham sp)
        {
            ItemControl item = new ItemControl();
            {
                item.Tag = sp.MaSP;
                item.TenSP = sp.TenSP;
                item.DonGia_S = sp.DonGia_S.ToString();
                item.DonGia_M = sp.DonGia_M.ToString();
                item.DonGia_L = sp.DonGia_L.ToString();
                item.DonGia_SP = sp.DonGia_SP.ToString()+ " ₫";
                item.BackgroundImage = MainFn.ByteArrayToImage(sp.AnhSP);
                item.MaLoai = sp.MaLoai;
                // Tạo sự kiện của sản phẩm đồ uống (Mã Loại đồ uống: ML01)
                if (item.MaLoai.Equals("ML01"))
                {
                    // Sự kiện đồ uống size S
                    item.btnSizeS.Click += (a, b) =>
                    {
                        if (item.SizeS)
                        {
                            PayControl pay = new PayControl();
                            {
                                pay.TenSP = item.TenSP;
                                pay.DonGia = item.DonGia_S;
                                pay.SizeSP = "Size S";
                                pay.Tag = item.Tag; // Thêm tên tag từng paycontrol với mã sản phẩm tương ứng.
                                pay.btnXoa.Click += (c, d) =>
                                {
                                    item.SizeS = false;
                                    if (!item.SizeS && !item.SizeM && !item.SizeL)
                                    {
                                        item.btnChecked.Visible = false;
                                        item.pnChecked.BorderColor = Color.Transparent;
                                        return;
                                    }
                                };
                            }
                            flplstMua.Controls.Add(pay);
                        }
                        else
                        {
                            var controlToRemove = flplstMua.Controls.OfType<PayControl>()
                            .FirstOrDefault(pay => pay.Tag.Equals(item.Tag) && pay.DonGia.Equals(item.DonGia_S));
                            if (controlToRemove != null)
                            {
                                flplstMua.Controls.Remove(controlToRemove);
                            }
                        }

                    };
                    // Sự kiện đồ uống size M
                    item.btnSizeM.Click += (a, b) =>
                    {

                        if (item.SizeM)
                        {
                            PayControl pay = new PayControl();
                            {
                                pay.TenSP = item.TenSP;
                                pay.DonGia = item.DonGia_M;
                                pay.SizeSP = "Size M";
                                pay.Tag = item.Tag; 
                                pay.btnXoa.Click += (c, d) =>
                                {
                                    item.SizeM = false;
                                    if (!item.SizeS && !item.SizeM && !item.SizeL)
                                    {
                                        item.btnChecked.Visible = false;
                                        item.pnChecked.BorderColor = Color.Transparent;
                                        return;
                                    }
                                };
                            }
                            flplstMua.Controls.Add(pay);
                        }
                        else
                        {
                            var controlToRemove = flplstMua.Controls.OfType<PayControl>()
                            .FirstOrDefault(pay => pay.Tag.Equals(item.Tag) && pay.DonGia.Equals(item.DonGia_M));
                            if (controlToRemove != null)
                            {
                                flplstMua.Controls.Remove(controlToRemove);
                            }
                        }

                    };
                    // Sự kiện đồ uống size L
                    item.btnSizeL.Click += (a, b) =>
                    {

                        if (item.SizeL)
                        {
                            PayControl pay = new PayControl();
                            {
                                pay.TenSP = item.TenSP;
                                pay.DonGia = item.DonGia_L;
                                pay.SizeSP = "Size L";
                                pay.Tag = item.Tag; 
                                pay.btnXoa.Click += (c, d) =>
                                {
                                    item.SizeL = false;
                                    if (!item.SizeS && !item.SizeM && !item.SizeL)
                                    {
                                        item.btnChecked.Visible = false;
                                        item.pnChecked.BorderColor = Color.Transparent;
                                        return;
                                    }
                                };
                            }
                            flplstMua.Controls.Add(pay);
                        }
                        else
                        {
                            var controlToRemove = flplstMua.Controls.OfType<PayControl>()
                            .FirstOrDefault(pay => pay.Tag.Equals(item.Tag) && pay.DonGia.Equals(item.DonGia_L));
                            if (controlToRemove != null)
                            {
                                flplstMua.Controls.Remove(controlToRemove);
                            }
                        }

                    }; 
                } // kết thúc if
                // Tạo sự kiện của sản phẩm đồ ăn (Mã Loại đồ uống: ML02)
                else
                {
                    item.Load += (a, b) =>
                        {
                            item.PnDonGia = true;
                            item.btnSizeS.Checked = true;
                            item.PnSizeState = (false, false);
                        };

                    item.pnChecked.Click += (a, b) =>
                    {
                        if (!item.btnChecked.Visible)
                        {
                            item.btnChecked.Visible = true;
                            item.pnChecked.BorderColor = Color.Tomato;
                            PayControl pay = new PayControl();
                            {
                                pay.TenSP = item.TenSP;
                                pay.DonGia = item.DonGia_SP;
                                pay.SizeSP = "";
                                pay.Tag = item.Tag; // thêm tên tag từng paycontrol với mã sản phẩm tương ứng.
                                pay.btnXoa.Click += (c, d) =>
                                {
                                    item.btnChecked.Visible = false;
                                    item.pnChecked.BorderColor = Color.Transparent;
                                };
                            }
                            flplstMua.Controls.Add(pay);
                        }
                        else
                        {
                            item.btnChecked.Visible = false;
                            item.pnChecked.BorderColor = Color.Transparent;
                            var controlToRemove = flplstMua.Controls.OfType<PayControl>()
                            .FirstOrDefault(Delpay => Delpay.Tag.Equals(item.Tag));
                            if (controlToRemove != null)
                            {
                                flplstMua.Controls.Remove(controlToRemove);
                            }
                        }

                    };

                }

            }

            flpSP.Controls.Add(item);
        }
       
        public void loadDanhMuc()
        {
            var lstSanPham = fn_SanPhamRespository.GetAllSanPham();
            lblSoLuong.Text = lstSanPham.Count().ToString() + "+ Sản Phẩm";
            flpSP.SuspendLayout();

            // LOAD flpSP sau khi sửa ( có trong lstSPUpdate, có trong flpSP)
            if (frmDoUong.lstSpUpdate.Any())
            {
                foreach (var item in flpSP.Controls.OfType<ItemControl>())
                {
                    if (frmDoUong.lstSpUpdate.Any(Masp => Masp.Equals(item.Tag)))
                    {
                        flpSP.Controls.Remove(item);
                        frmDoUong.lstSpUpdate.Clear();
                    }
                }
            }

            // LOAD flpSP sau khi thêm ( có trong lstSanPham, không có trong flpSP)
            var lstSanPhamThem = lstSanPham.Where(sp => !flpSP.Controls.OfType<ItemControl>().Any(item => item.Tag.Equals(sp.MaSP))).ToList();
            if (lstSanPhamThem.Count > 0)
            {
                foreach (var sp in lstSanPhamThem)
                {
                    AddSanPham(sp);
                }
            }
           

            // LOAD flpSP sau khi xóa ( có trong flpSP, không có trong lstSanPham)
            foreach (var item in flpSP.Controls.OfType<ItemControl>())
            {
                if (!lstSanPham.Any(sp => sp.MaSP.Equals(item.Tag)))
                {
                    flpSP.Controls.Remove(item);
                }
            }

            flpSP.ResumeLayout();
        }

        public void TimKiemSP(string TimKiem)
        {
            foreach (var item in flpSP.Controls)
            {
                var i = (ItemControl)item;
                i.Visible = i.TenSP.Trim().ToLower().Contains(TimKiem.Trim().ToLower());
            }
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            btnPhanLoaiTatCa.Checked = true;
            timer1.Start();
            flpSP.HorizontalScroll.Maximum = 0;
            flpSP.HorizontalScroll.Visible = false;
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flpSP, gunaVScrollBar1, true);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flplstMua, gunaVScrollBar2, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTGHienTai.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void btnPhanLoaiDoUong_Click(object sender, EventArgs e)
        {
            // Ẩn những sản phẩm có mã loại khác với mã loại ML01 ( Đồ Uống)
            foreach(var item in flpSP.Controls)
            {
                var i = (ItemControl)item;
                if(!i.MaLoai.Equals("ML01"))
                    i.Visible= false;
                else 
                    i.Visible = true;
            }    
        }

        private void btnPhanLoaiDoAn_Click(object sender, EventArgs e)
        {
            // Ẩn những sản phẩm có mã loại khác với mã loại ML02 ( Đồ Ăn)
            foreach (var item in flpSP.Controls)
            {
                var i = (ItemControl)item;
                if (!i.MaLoai.Equals("ML02"))
                    i.Visible = false;
                else
                    i.Visible = true;
            }
        }

        private void btnPhanLoaiTatCa_Click(object sender, EventArgs e)
        {
            // Hiện tất cả các sản phẩm
            foreach (var item in flpSP.Controls)
            {
                var i = (ItemControl)item;
                    i.Visible = true;
            }
        }
    }
}
