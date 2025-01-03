using Phan_Mem_Quan_Ly.Respository;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class frmLichSuSuKien : Form
    {
        public frmLichSuSuKien()
        {
            InitializeComponent();
        }

        private void frmLichSuSuKien_Load(object sender, EventArgs e)
        {
            try
            {
                var lst = fn_SuKienRespository.GetAllLichSuSuKien();
                lichSuSuKienBindingSource.DataSource = lst;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi :" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
