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
    public partial class Form_Trang_DN : Form
    {
        public Form_Trang_DN()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Form_Dang_Nhap_Admincs adim = new Form_Dang_Nhap_Admincs();
            adim.Show();
            
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Form_ĐangNhap_NV nhanvien = new Form_ĐangNhap_NV();
            nhanvien.Show();
            
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            Form_Dang_Nhap_KH khachhang = new Form_Dang_Nhap_KH();
            khachhang.Show();
            
        }
    }
}
