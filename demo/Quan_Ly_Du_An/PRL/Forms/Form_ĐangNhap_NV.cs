using BUS.Service;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Form_ĐangNhap_NV : Form
    {
        private NhanVienService _service;
        private int _Click;
        public Form_ĐangNhap_NV()
        {
            InitializeComponent();
            _service = new NhanVienService();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            Form_Trang_DN dangnhap = new Form_Trang_DN();
            dangnhap.Show();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_TaiKhoan.Text.Trim();
            string matKhau = txt_MatKhau.Text;
            var ad = _service.GetNVs(tenDangNhap);
            Admin admin = new Admin();
            if (ad != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form_NhanVien nv = new Form_NhanVien();
                nv.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

        }
    }
}
