using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Types;
using Twilio.TwiML;
using System.Data.Common;
using Twilio.Rest.Api.V2010.Account;

namespace SunShine_HRMs.View
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            txtSoDienThoai.Focus();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void txtSoDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoDienThoai.Text == "")
            {
                errorProvider.SetError(txtSoDienThoai, "Vui lòng nhập số điện thoại!");
            }
        }
        public class randomMa
        {
            static public int ma;
        }
        int random()
        {
            Random rnd = new Random();
            int ma = rnd.Next(100000, 999999);
            return ma;
        }

        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.TextLength == 12)
            {
                randomMa.ma = random();
                /*
                try
                {
                    const string acountsid = "AC0bc37877cb529b3e962231c1dfdf166b";
                    const string autotoken = "30c9cea82f4375ba4325a95c222f6dcf";
                    TwilioClient.Init(acountsid, autotoken);
                    var message = MessageResource.Create(body: "Your code: " + randomMa.ma, from: new Twilio.Types.PhoneNumber("+14156305841"), to: new Twilio.Types.PhoneNumber("+84848110357"));
                    MessageBox.Show("Message Sent");
                    frmXacThucMa f2 = new frmXacThucMa();
                    f2.Show();
                }
                catch (Exception ex) { MessageBox.Show("Error" + ex.Message); }
                */
                MessageBox.Show(randomMa.ma.ToString());
                frmXacThucMa frm = new frmXacThucMa();
                this.Hide();
                frm.Show();
            }
            else errorProvider.SetError(txtSoDienThoai, "Số điện thoại không đúng định dạng");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

    }
}
