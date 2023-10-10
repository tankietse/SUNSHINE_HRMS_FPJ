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
    public partial class HR_ui_Main : Form
    {

        bool SidebarExpand = false;
        public HR_ui_Main()
        {
            InitializeComponent();
        }

        //Error
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                Sidebar.Width -= 2;
                if (Sidebar.Width <= 60)
                {
                    SidebarExpand = false;
                    SidebarTransition.Stop();
                    
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
                lblMode.Visible = false;
            }
            else
            {
                Sidebar.Width += 2;
                if (Sidebar.Width >= 183)
                {
                    SidebarExpand = true;
                    SidebarTransition.Stop();

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
                lblMode.Visible = true;
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
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
