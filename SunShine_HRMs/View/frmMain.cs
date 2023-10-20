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
    public partial class frmMain : Form
    {

        bool SidebarExpand;
        bool HomeCollapsed;
        public frmMain()
        {
            InitializeComponent();
        }

        //Error
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                pnlSidebar.Width -= 2;  
                if (pnlSidebar.Width <= 60)
                {
                    SidebarExpand = false;
                    SidebarTransitionTimer.Stop();

                    //btnDashboard
                    //btnBaoCao 
                    //btnCongDong 
                    //btnLich 
                    //btnThongKe 
                    //pnCaiDat 
                    //pnMode 
                    //pnMainMenu 
                }

                lblCaiDat.Visible = false;
                lblMainMenu.Visible = false;
            }
            else
            {
                pnlSidebar.Width += 2;
                if (pnlSidebar.Width >= 183)
                {
                    SidebarExpand = true;
                    SidebarTransitionTimer.Stop();

                    //btnDashboard 
                    //btnBaoCao 
                    //btnCongDong 
                    ////btnLich 
                    ////btnThongKe 
                    //pnCaiDat 
                    //pnMode 
                    //pnMainMenu 
                }
                lblCaiDat.Visible = true;
                lblMainMenu.Visible = true;
            }
        }

        
        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransitionTimer.Start();
        }

    }
}
