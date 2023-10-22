using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunShine_HRMs.Model;

namespace SunShine_HRMs.View
{
    public partial class ThongTinTaiKhoan : Form
    {
        string IDNV = "NV10";
        bool textboxesEnabled = false;
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadThongTinNhanVien();
            SetTextboxesEnabled(false);
        }

        private void LoadThongTinNhanVien()
        {
            using (var dbcontext = new HRMContext())
            {
                var nhanvien = dbcontext.NHANVIENs.FirstOrDefault(x => x.ID == IDNV);
                if (nhanvien == null)
                {
                    MessageBox.Show("Bạn cần đăng nhập để xem thông tin!");
                    return;
                }

                lbName.Text = nhanvien.HoDem + nhanvien.Ten;

                var chucvu = dbcontext.CHUCVUs.FirstOrDefault(x => x.ID == nhanvien.IDChucVu);
                if (chucvu == null) return;
                var vitri = dbcontext.VITRICVs.FirstOrDefault(x => x.ID == nhanvien.IDViTri);
                if (vitri == null) return;

                lbVaitro.Text = chucvu.TenChucVu;
                txtID.Text = nhanvien.ID;
                txtTen.Text = nhanvien.HoDem + nhanvien.Ten;
                txtNS.Text = nhanvien.NgaySinh.ToString();
                txtGioiTinh.Text = nhanvien.GioiTinh == true ? "Nam" : "Nữ";
                txtCCCD.Text = nhanvien.CCCD;
                txtSdt.Text = nhanvien.SDT;
                txtVitri.Text = vitri.TenVitri;
                txtChucvu.Text = chucvu.TenChucVu;
                txtEmail.Text = nhanvien.SDT;
                txtDiaChi.Text = nhanvien.SDT;
                txtQuequan.Text = nhanvien.SDT;
                txtNTD.Text = nhanvien.SDT;
            }
        }

        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            if (!textboxesEnabled)
            {
                SetTextboxesEnabled(true);
                SetTextboxesEnableWithRole();
                btnThaydoi.Text = "Cập Nhật";
            }
            else
            {
                SetTextboxesEnabled(false);
                btnThaydoi.Text = "Thay Đổi";
                CapNhatThongTin();
            }
        }

        private void CapNhatThongTin()
        {
            using (var dbcontext = new HRMContext())
            {
                NHANVIEN nhanvien = dbcontext.NHANVIENs.FirstOrDefault(x => x.ID.ToString() == IDNV);
                if (nhanvien != null)
                {
                    NHANVIEN updateNV = new NHANVIEN();

                    string[] name = txtTen.Text.Split(' ');
                    if (name.Length < 2) return;
                    string Hodem = name[0];
                    string Ten = name[1];

                    DateTime ngayTuyenDung;
                    if (DateTime.TryParseExact(txtNTD.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayTuyenDung))
                    {
                        updateNV.NgayTuyenDung = ngayTuyenDung;
                    }
                    else
                    {
                        MessageBox.Show("Ngày tuyển dụng không hợp lệ!");
                    }

                    DateTime ngaySinh;
                    if (DateTime.TryParseExact(txtNS.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                    {
                        updateNV.NgaySinh = ngaySinh;
                    }
                    else
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ!");
                    }

                    updateNV.ID = txtID.Text;
                    updateNV.HoDem = Hodem;
                    updateNV.Ten = Ten;
                    updateNV.NgaySinh = ngaySinh;
                    updateNV.GioiTinh = txtGioiTinh.Text == "Name" ? true : false;
                    updateNV.CCCD = txtCCCD.Text;
                    updateNV.SDT = txtSdt.Text;
                    updateNV.Email = txtEmail.Text;
                    updateNV.DiaChi = txtDiaChi.Text;
                    updateNV.QueQuan = txtQuequan.Text;
                    updateNV.NgayTuyenDung = ngayTuyenDung;

                    dbcontext.SaveChanges(); 
                    SetTextboxesEnabled(false);
                    LoadThongTinNhanVien();
                    btnThaydoi.Text = "Thay Đổi";
                }
            }
        }

        private void SetTextboxesEnabled(bool enable)
        {
            txtID.Enabled = enable;
            txtChucvu.Enabled = enable;
            txtVitri.Enabled = enable;
            txtTen.Enabled = enable;
            txtNS.Enabled = enable;
            txtGioiTinh.Enabled = enable;
            txtCCCD.Enabled = enable;
            txtSdt.Enabled = enable;
            txtEmail.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtQuequan.Enabled = enable;
            txtNTD.Enabled = enable;
        }

        private void SetTextboxesEnableWithRole()
        {
            using (var dbcontext = new HRMContext())
            {
                var nhanvien = dbcontext.NHANVIENs.FirstOrDefault(x => x.ID == IDNV);
                if (nhanvien == null) return;
                txtID.Enabled = nhanvien.IDChucVu.ToString() != "3" ? true : false;
                txtChucvu.Enabled = nhanvien.IDChucVu.ToString() != "3" ? true : false;
                txtVitri.Enabled = nhanvien.IDChucVu.ToString() != "3" ? true : false;
            }
        }
    }
}
