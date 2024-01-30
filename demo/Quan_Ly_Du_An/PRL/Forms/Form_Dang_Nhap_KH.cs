using BUS.Service;
using DAL.DomainClass;
using Microsoft.Data.SqlClient;
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
    public partial class Form_Dang_Nhap_KH : Form
    {
        private KhachHangService _service;
        private int _click;
        public Form_Dang_Nhap_KH()
        {
            InitializeComponent();
            _service = new KhachHangService();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            Form_Trang_DN dn = new Form_Trang_DN();
            dn.Show();
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_TênTK.Text.Trim();
            string matKhau = txt_MatKhau.Text;

            string sqlKiemtra = "SELECT * FROM Admin WHERE TaiKhoan = '" + tenDangNhap + "' AND MatKhau = '" + matKhau + "'";

            // Thực hiện câu truy vấn SQL (lưu ý: việc sử dụng câu truy vấn này có thể dẫn đến vấn đề bảo mật SQL Injection)
            var ad = _service.GetKH(sqlKiemtra);

            if (ad != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form_Khach_Hang kh = new Form_Khach_Hang();
                kh.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }

            ////////////////////////////////////////////

           
         }
        }
 }

