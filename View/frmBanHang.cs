﻿using Phan_Mem_Quan_Ly.Model;
using Phan_Mem_Quan_Ly.PartialView;
using Phan_Mem_Quan_Ly.Respository;
using Phan_Mem_Quan_Ly.TabControl;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
                item.GiamGia = sp.GiamGia.ToString() + "%";
                item.BackgroundImage = MainFn.ByteArrayToImage(sp.AnhSP);
                item.MaLoai = sp.MaLoai;
                // Tạo sự kiện của sản phẩm đồ uống (Mã Loại đồ uống: ML01)
                if (item.MaLoai.Equals("ML01"))
                {

                    // Sự kiện đồ uống size S
                    item.btnSizeS.Click += (a, b) =>
                    {
                        if (Convert.ToDecimal(item.DonGia_S) == 0.0m)
                        {
                            ToastMSS mss = new ToastMSS("Xin lỗi đã hết size S !", "SAD");
                            mss.Show();
                            return;
                        }
                        else
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
                        }
                    };

                    // Sự kiện đồ uống size M
                    item.btnSizeM.Click += (a, b) =>
                    {
                        if (Convert.ToDecimal(item.DonGia_M) == 0.0m)
                        {
                            ToastMSS mss = new ToastMSS("Xin lỗi đã hết size M !", "SAD");
                            mss.Show();
                        }
                        else
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
                        }

                    };

                    // Sự kiện đồ uống size L
                    item.btnSizeL.Click += (a, b) =>
                    {
                        if (Convert.ToDecimal(item.DonGia_L) == 0.0m)
                        {
                            ToastMSS mss = new ToastMSS("Xin lỗi đã hết size L !", "SAD");
                            mss.Show();
                        }
                        else
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
                                pay.ThanhTien = item.DonGia_SP;
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
        private string TinhThanhTienPayCtrl(string strDonGia, string strGiamGia)
        {
            decimal GiamGia = ((decimal)(100 - int.Parse(strGiamGia.Replace("%", ""))) / 100);
            decimal ThanhTien = decimal.Parse(strDonGia) * GiamGia;
            return ThanhTien.ToString("F2");
        }
        private void CreatePayCtrl(ItemControl item, string size)
        {
            PayControl pay = new PayControl();
            {
                pay.TenSP = item.TenSP;
                pay.ThanhTien = (size.Equals("Size S")) ? TinhThanhTienPayCtrl(item.DonGia_S, item.GiamGia) :
                    ((size.Equals("Size M")) ? TinhThanhTienPayCtrl(item.DonGia_M, item.GiamGia) : TinhThanhTienPayCtrl(item.DonGia_L, item.GiamGia));
                pay.SizeSP = size;
                pay.Tag = item.Tag; // Thêm tên tag từng paycontrol với mã sản phẩm tương ứng.
                pay.btnXoa.Click += (a, b) =>
                {
                    switch (size)
                    {
                        case "Size S": item.SizeS = false; break;
                        case "Size M": item.SizeM = false; break;
                        case "Size L": item.SizeL = false; break;
                    }
                    if (!item.SizeS && !item.SizeM && !item.SizeL)
                    {
                        item.btnChecked.Visible = false;
                        item.pnChecked.BorderColor = Color.Transparent;
                        return;
                    }
                    TinhTongTien();
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
        private void TinhTongTien()
        {
            decimal TongTien = flplstMua.Controls.OfType<PayControl>().Sum(p => decimal.Parse(p.ThanhTien));
            lblThanhTien.Text = TongTien.ToString("C", new CultureInfo("vi-VN"));
        }
        public void loadDanhMuc()
        {
            var lstSanPham = fn_SanPhamRespository.GetAllSanPham();
            if (lstSanPham.Any())
            {
                lblSoLuong.Text = lstSanPham.Count().ToString() + "+ Sản Phẩm";
            }
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
            // LOAD flpSP sau khi xóa ( có trong flpSP, không có trong lstSanPham)
            foreach (var item in flpSP.Controls.OfType<ItemControl>())
            {
                if (!lstSanPham.Any(sp => sp.MaSP.Equals(item.Tag)))
                {
                    flpSP.Controls.Remove(item);
                }
            }
            // LOAD flpSP sau khi thêm ( có trong lstSanPham, không có trong flpSP)
            var lstSanPhamThem = lstSanPham.Where(sp => !flpSP.Controls.OfType<ItemControl>().Any(item => item.Tag.Equals(sp.MaSP))).ToList();
            if (lstSanPhamThem.Any())
            {
                foreach (var sp in lstSanPhamThem)
                {
                    AddSanPham(sp);
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
        Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper;
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            btnPhanLoaiTatCa.Checked = true;
            timer1.Start();
            flpSP.HorizontalScroll.Maximum = 0;
            flpSP.HorizontalScroll.Visible = false;
            flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flpSP, gunaVScrollBar1, true);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flplstMua, gunaVScrollBar2, true);
            try
            {
                var lstKH = fn_KhachHangRespository.GetAllKhachHang();
                khachHangBindingSource.DataSource = lstKH;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi load combox khách hàng: " + ex.Message);
            }
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
            lblSoLuong.Text = flpSP.Controls.OfType<ItemControl>().Count(i => i.Visible).ToString() + "+ Sản Phẩm";
            flowphelper.UpdateScrollBar();
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
            lblSoLuong.Text = flpSP.Controls.OfType<ItemControl>().Count(i => i.Visible).ToString() + "+ Sản Phẩm";
            flowphelper.UpdateScrollBar();
        }

        private void btnPhanLoaiTatCa_Click(object sender, EventArgs e)
        {
            // Hiện tất cả các sản phẩm
            foreach (var item in flpSP.Controls)
            {
                var i = (ItemControl)item;
                i.Visible = true;
            }
            lblSoLuong.Text = flpSP.Controls.OfType<ItemControl>().Count(i => i.Visible).ToString() + "+ Sản Phẩm";
            flowphelper.UpdateScrollBar();
        }
        public bool checkHD = false;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (flplstMua.Controls.OfType<PayControl>().Any())
                {
                    var hd = new HoaDon();
                    {
                        hd.MaKH = Convert.ToString(cbKhachHang.SelectedValue);
                        hd.MaNV = frmTrangChu.Instance.MaNV;
                        hd.MaSK = fn_SuKienRespository.LayMaSuKien();
                        foreach (var item in flplstMua.Controls)
                        {
                            var i = (PayControl)item;
                            hd.ChiTietHD.Rows.Add(i.Tag, i.nudSoLuong.Value, i.DonGia, i.ThanhTien);
                        }
                    }
                    bool result = fn_HoaDonRespository.AddHoaDon(hd);
                    if (result)
                    {
                        ToastMSS mss = new ToastMSS("Tạo Hóa Đơn Thành Công !", "SUCCESS");
                        mss.Show();
                        checkHD = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    ToastMSS toast = new ToastMSS("Vui lòng chọn đồ !", "INFO");
                    toast.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm :" + ex.Message);
            }
        }

        private void txtSoTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            decimal ThanhTien = decimal.Parse(lblThanhTien.Text.Replace(" ₫", ""));
            if (!string.IsNullOrEmpty(txtSoTienKhachDua.Text))
            {
                decimal SoTienKhachDua = decimal.Parse(txtSoTienKhachDua.Text);
                if (ThanhTien > 0 && SoTienKhachDua >= ThanhTien)
                {
                    decimal SoTienTra = SoTienKhachDua - ThanhTien;
                    txtSoTienTra.Text = SoTienTra.ToString("C", new CultureInfo("vi-VN"));
                }
            }
        }
    }
}
