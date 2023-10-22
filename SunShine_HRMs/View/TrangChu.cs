using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunShine_HRMs
{
    public partial class frmTrangChu : Form
    {

        bool SidebarExpand;
        bool HomeCollapsed;
        public frmTrangChu()
        {
            InitializeComponent();
        }

        //Error
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                pnlSidebar.Width -= 2;
                //if (pnlSidebar.Width == pnlSidebar.MinimumSize.Width)   
                if (pnlSidebar.Width <= 60)
                {
                    SidebarExpand = false;
                    SidebarTransitionTimer.Stop();

                    //btnDashboard.Width = Sidebar.Width;
                    //btnBaoCao.Width = Sidebar.Width;
                    //btnCongDong.Width = Sidebar.Width;
                    //btnLich.Width = Sidebar.Width;
                    //btnThongKe.Width = Sidebar.Width;
                    //pnCaiDat.Width = Sidebar.Width;
                    //pnMode.Width = Sidebar.Width;
                    //pnMainMenu.Width = Sidebar.Width;
                }

                lblCaiDat.Visible = false;
                lblMainMenu.Visible = false;
            }
            else
            {
                pnlSidebar.Width += 2;
                //if (pnlSidebar.Width == pnlSidebar.MaximumSize.Width)
                if (pnlSidebar.Width >= 183)
                {
                    SidebarExpand = true;
                    SidebarTransitionTimer.Stop();

                    //btnDashboard.Width = Sidebar.Width;
                    //btnBaoCao.Width = Sidebar.Width;
                    //btnCongDong.Width = Sidebar.Width;
                    ////btnLich.Width = Sidebar.Width;
                    ////btnThongKe.Width = Sidebar.Width;
                    //pnCaiDat.Width = Sidebar.Width;
                    //pnMode.Width = Sidebar.Width;
                    //pnMainMenu.Width = Sidebar.Width;
                }
                lblCaiDat.Visible = true;
                lblMainMenu.Visible = true;
            }
        }

        private void TaiKhoanTimer_Tick(object sender, EventArgs e)
        {
            if (HomeCollapsed)
            {
                pnlTaiKhoan.Height -= 2;
                if (pnlTaiKhoan.Height <= 54)
                {
                    HomeCollapsed = false;
                    TaiKhoanTimer.Stop();
                }

            }
            else
            {
                pnlTaiKhoan.Height += 2;
                if (pnlTaiKhoan.Height >= 179)
                {
                    HomeCollapsed = true;
                    TaiKhoanTimer.Stop();
                }
            }
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransitionTimer.Start();
        }

        private void btnXemTacVuKhac_Click(object sender, EventArgs e)
        {
            TaiKhoanTimer.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnLich_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTuyendung_Click(object sender, EventArgs e)
        {

        }

    }
}
