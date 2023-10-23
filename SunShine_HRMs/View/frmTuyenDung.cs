using SunShine_HRMs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunShine_HRMs.View
{
    public partial class frmTuyenDung : Form
    {
        Model1 DBcontext = new Model1();
        public frmTuyenDung()
        {
            InitializeComponent();
        }

        private void frmTuyenDung_Load(object sender, EventArgs e)
        {
            Loard_dgv();

        }

        private void Loard_dgv()
        {
            dgvTTTuyenDung.DataSource = DBcontext.UNGVIENs.ToList();
        }
    }
}
