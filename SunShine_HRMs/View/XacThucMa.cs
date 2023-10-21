using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SunShine_HRMs.View
{
    public partial class frmXacThucMa : Form
    {
        System.Timers.Timer t;
        int m = 0, s = 10; bool guima=true;
        public frmXacThucMa()
        {
            InitializeComponent();
        }

        private void XacThucMa_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
            CaiDatChucNang();
        }

        private void CaiDatChucNang()
        {
            if (guima == true)
                btnTiepTuc.Enabled = true;
            else btnTiepTuc.Enabled = false;
        }

        private void btnGuiLaiMa_Click(object sender, EventArgs e)
        {
            guima = true;
            s = 10;
            CaiDatChucNang();
            t.Start();
            frmQuenMatKhau frm = new frmQuenMatKhau();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (txtNhapMa.Text == frmQuenMatKhau.randomMa.ma.ToString())
            {
                frmDoiMatKhau frm = new frmDoiMatKhau();
                this.Hide();
                frm.Show();
            }
            else MessageBox.Show("Mã không chính xác!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frm = new frmQuenMatKhau();
            this.Hide();
            frm.Show();
        }

        private void OnTimeEvent(object sender,System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (s == 0)
                {
                    s = 59;
                    m -= 1;
                }
                else
                {
                    s -= 1;
                }
                txtThoiGian.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
            if (m == 0 && s == 0)
            {
                guima = false;
                t.Stop();
            }
            CaiDatChucNang();
        }
        
    }
}
