using SunShine_HRMs.Model;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        HRMs dbcontext = new HRMs();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = dbcontext.TAIKHOANs.FirstOrDefault(p => p.MatDangNhap == txtUsername.Text && p.MatKhau == txtPassword.Text);
            if(tk != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                HR_ui_Main frm = new HR_ui_Main();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            TAIKHOAN tk = dbcontext.TAIKHOANs.FirstOrDefault(p => p.MatDangNhap == txtUsername.Text);
            if (txtUsername.Text == "")
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider.SetError(txtUsername, "Vui lòng nhập mật khẩu!");
            }
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            this.Hide();
            frm.Show();
        }
    }
}
