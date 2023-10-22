using SunShine_HRMs.View;
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
                lblMainMenu.Visible = false;
                pnlLogo.Visible = false;
            }
            else
            {
                pnlSidebar.Width += 2;
                if (pnlSidebar.Width >= 164)
                {
                    SidebarExpand = true;
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
                lblMainMenu.Visible = true;
                pnlLogo.Visible = true;
            }
        }

        
        private void btnHam_Click(object sender, EventArgs e)
        {
            SidebarTransitionTimer.Start();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            frmTrangChinh frm = new frmTrangChinh();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
