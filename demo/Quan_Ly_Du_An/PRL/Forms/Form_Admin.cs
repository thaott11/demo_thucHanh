using BUS.ServiceNV;
using DAL.DomainClass;
using DAL.NhanVienRepstory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class Form_Admin : Form
    {
        private AdminService _service;
        private int _idWhenClick;
        public Form_Admin()
        {
            InitializeComponent();
            _service = new AdminService();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
           
            var nv = new NhanVien();
            nv.Id = int.Parse(txt_idNV.Text);
            nv.Ten = txt_TenNV.Text;
            nv.Email = txt_EmailNV.Text;
            nv.Sdt = int.Parse(txt_SĐTNV.Text);
            nv.Diachi = txt_DiaChiNV.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(nv));
            }
            else
            {
                return;
            }
        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            //stt
            int stt = 1;
            // xac dinh, dtg se co bnh cot
            dtg_view.ColumnCount = 6;
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID";
            dtg_view.Columns[2].Name = "Ten";
            dtg_view.Columns[3].Name = "Địa Chỉ";
            dtg_view.Columns[4].Name = "SĐT";
            dtg_view.Columns[5].Name = "Email";            
            dtg_view.Rows.Clear();
            foreach (var sv in _service.GetNVs(txt_Seach.Text))
            {
                dtg_view.Rows.Add(stt++, sv.Id, sv.Ten, sv.Diachi, sv.Sdt, sv.Email);
            }
        }
        private void btn_SuaNV_Click(object sender, EventArgs e)
        {

            var sv = new NhanVien();
            sv.Id = _idWhenClick;
            sv.Ten = txt_TenNV.Text;
            sv.Email = txt_EmailNV.Text;
            sv.Sdt = int.Parse(txt_SĐTNV.Text);
            sv.Diachi = txt_DiaChiNV.Text;

            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(sv));
            }
            else
            {
                return;
            }
        }
        
        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            var sp = new Sanpham();
            sp.Id = int.Parse(txt_IDSanPham.Text);
            sp.Ten = txt_TenSP.Text;
            sp.Mota = txt_MoTa.Text;
            sp.Soluongtonkho = int.Parse(txt_SoLuongSP.Text);
            sp.Giatien = int.Parse(txt_GiaSP.Text);


            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(sp));
            }
            else
            {
                return;
            }
        }

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
            var sp = new Sanpham();
            sp.Id = _idWhenClick;
            sp.Ten = txt_TenSP.Text;
            sp.Mota = txt_MoTa.Text;
            sp.Soluongtonkho = int.Parse(txt_SoLuongSP.Text);
            sp.Giatien = int.Parse(txt_GiaSP.Text);
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(sp));
                
            }
            else
            {
                return;
            }
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            var sp = new Sanpham();
            sp.Id = int.Parse(txt_Seach.Text);
            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(sp));
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_view.ColumnCount = 6;
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID";
            dtg_view.Columns[2].Name = "Ten";
            dtg_view.Columns[3].Name = "Mô Tả";
            dtg_view.Columns[4].Name = "Số lượng kho";
            dtg_view.Columns[5].Name = "Giá tền";
            dtg_view.Rows.Clear();
            foreach (var sp in _service.GetSPs(txt_Seach.Text))
            {
                dtg_view.Rows.Add(stt++, sp.Id, sp.Ten, sp.Mota, sp.Soluongtonkho, sp.Giatien);
            }
        }

        private void btn_ThongTinKH_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_view.ColumnCount = 6;
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID";
            dtg_view.Columns[2].Name = "Ten KH";
            dtg_view.Columns[3].Name = "Địa Chỉ";
            dtg_view.Columns[4].Name = "Số ĐT";
            dtg_view.Columns[5].Name = "Đánh Giá";
           
            dtg_view.Rows.Clear();
            foreach (var kh in _service.GetKHs(txt_Seach.Text))
            {
                dtg_view.Rows.Add(stt++, kh.Id, kh.TenKhachHang, kh.DiaChi, kh.DienThoai, kh.DanhGia);
            }
        }

        private void btn_ThongTinDH_Click(object sender, EventArgs e)
        {
            int stt = 1;           
            dtg_view.ColumnCount = 9;           
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID";
            dtg_view.Columns[2].Name = "Ngày Xuất Đơn";
            dtg_view.Columns[3].Name = "Tình Trạng";
            dtg_view.Columns[4].Name = "Tên Sản Phẩm";
            dtg_view.Columns[5].Name = "Số lượng Mua";
            dtg_view.Columns[6].Name = "Tên Người Mua";
            dtg_view.Columns[7].Name = "Giá HĐ";
            dtg_view.Columns[8].Name = "Ghi Chú";           
            dtg_view.Rows.Clear();
            foreach (var dh in _service.GetDHs(txt_Seach.Text))
            {
                dtg_view.Rows.Add(stt++, dh.Id, dh.Ngayxuatdon, dh.Tinhtrangdh, dh.TenSanPham, dh.SoLuongMua, dh.TenNguoiMua, dh.Giadh, dh.Ghichu);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void Form_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
