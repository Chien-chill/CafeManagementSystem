using System;
using System.Drawing;
using System.Windows.Forms;

namespace Phan_Mem_Quan_Ly.PartialView
{
    public partial class ToastMSS : Form
    {
        public ToastMSS(string noidung, string type)
        {
            InitializeComponent();
            lblNoiDung.Text = noidung;
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            X = ScreenWidth - this.Width - 10;
            Y = ScreenHeight - this.Height;
            this.Location = new Point(X, Y);
            switch (type)
            {
                case "INFO":
                    this.BackColor = Color.FromArgb(120, 162, 210);
                    pcbIcon.Image = Phan_Mem_Quan_Ly.Properties.Resources.icons8_info_50;
                    break;
                case "SUCCESS":
                    this.BackColor = Color.FromArgb(56, 180, 123);
                    pcbIcon.Image = Phan_Mem_Quan_Ly.Properties.Resources.icons8_checked_32;
                    break;
                case "DELETE":
                    this.BackColor = Color.FromArgb(238, 62, 84);
                    pcbIcon.Image = Phan_Mem_Quan_Ly.Properties.Resources.icons8_cancel_24;
                    break;
            }
        }
        int X, Y;

        private void timerShow_Tick(object sender, EventArgs e)
        {
            Y -= 10;
            this.Location = new Point(X, Y);
            if (Y < 960)
            {
                timerShow.Stop();
                timerHide.Start();
            }
        }
        int y = 100;
        private void timerHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                Y += 1;
                this.Location = new Point(X, Y += 10);
                if (Y > 800)
                {
                    timerHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }
    }
}
