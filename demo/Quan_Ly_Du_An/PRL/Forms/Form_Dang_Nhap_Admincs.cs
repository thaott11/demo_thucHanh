using BUS.ServiceNV;
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
    public partial class Form_Dang_Nhap_Admincs : Form
    {
        private AdminService _service;
        private int _Ckick;
        public Form_Dang_Nhap_Admincs()
        {
            InitializeComponent();
            _service = new AdminService();
        }



        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Quaylai_Click(object sender, EventArgs e)
        {
            Form_Trang_DN dangnhap = new Form_Trang_DN();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_Tentk.Text.Trim();
            string matKhau = txt_MatKhau.Text;

            // Lấy thông tin Admin từ dịch vụ hoặc cơ sở dữ liệu
            var ad = _service.GetAdmin(tenDangNhap, matKhau);
            Admin admin = new Admin();
            if (ad != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form_Admin adm = new Form_Admin();
                adm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

        }
    }
}  

