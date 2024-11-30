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
                item.DonGia_SP = sp.DonGia_SP.ToString();
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
                            CreatePayCtrl(item, "Size S");
                        }
                        else
                        {
                            DeletePayCtrl(item, "Size S");
                        }
                        TinhTongTien();
                    };
                    // Sự kiện đồ uống size M
                    item.btnSizeM.Click += (a, b) =>
                    {

                        if (item.SizeM)
                        {
                            CreatePayCtrl(item, "Size M");

                        }
                        else
                        {
                            DeletePayCtrl(item, "Size M");
                        }
                        TinhTongTien();
                    };
                    // Sự kiện đồ uống size L
                    item.btnSizeL.Click += (a, b) =>
                    {

                        if (item.SizeL)
                        {
                            CreatePayCtrl(item, "Size L");
                        }
                        else
                        {
                            DeletePayCtrl(item, "Size L");
                        }
                        TinhTongTien();

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
                                    TinhTongTien();
                                    item.btnChecked.Visible = false;
                                    item.pnChecked.BorderColor = Color.Transparent;

                                };
                                pay.nudSoLuong.ValueChanged += (sender, e) =>
                                {
                                    TinhTongTien();
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
                        TinhTongTien();
                    };

                }

            }

            flpSP.Controls.Add(item);
        }
        private void CreatePayCtrl(ItemControl item, string size)
        {
            PayControl pay = new PayControl();
            {
                pay.TenSP = item.TenSP;
                pay.DonGia =(size.Equals("Size S"))? item.DonGia_S:((size.Equals("Size M"))?item.DonGia_M: item.DonGia_L);
                pay.SizeSP = size;
                pay.Tag = item.Tag; // Thêm tên tag từng paycontrol với mã sản phẩm tương ứng.
                pay.btnXoa.Click += (c, d) =>
                {
                    switch (size)
                    {
                        case "Size S": item.SizeS = false; break;
                        case "Size M": item.SizeM = false; break;
                        case "Size L": item.SizeL = false; break;
                    }
                    if (!item.SizeS && !item.SizeM && !item.SizeL)
                    {
                        TinhTongTien();
                        item.btnChecked.Visible = false;
                        item.pnChecked.BorderColor = Color.Transparent;
                        return;
                    }
                };
                pay.nudSoLuong.ValueChanged += (c, d) =>
                {
                    TinhTongTien();
                };
            }
            flplstMua.Controls.Add(pay);
        }
        private void DeletePayCtrl(ItemControl item, string size)
        {
            var controlToRemove = flplstMua.Controls.OfType<PayControl>()
            .FirstOrDefault(pay => pay.Tag.Equals(item.Tag) && pay.SizeSP.Equals(size));
            if (controlToRemove != null)
            {
                flplstMua.Controls.Remove(controlToRemove);
            }
        }
        public void TinhTongTien()
        {
            decimal TongTien = flplstMua.Controls.OfType<PayControl>().Sum(p => decimal.Parse(p.DonGia));
            lblThanhTien.Text = TongTien.ToString("C", new CultureInfo("vi-VN"));
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
            foreach (var item in flpSP.Controls)
            {
                var i = (ItemControl)item;
                if (!i.MaLoai.Equals("ML01"))
                    i.Visible = false;
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = new HoaDon();
                {
                    hd.MaKH = "KH01";
                    hd.MaNV = "NV01";
                    hd.MaSK = "SK01";
                    foreach (var item in flplstMua.Controls)
                    {
                        var i = (PayControl)item;
                        hd.ChiTietHD.Rows.Add(i.Tag, i.nudSoLuong.Value, i.DonGia);
                    }
                }
                bool result = fn_HoaDonRespository.AddHoaDon(hd);
                if (result)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm :" + ex.Message);
            }
        }
    }
}
