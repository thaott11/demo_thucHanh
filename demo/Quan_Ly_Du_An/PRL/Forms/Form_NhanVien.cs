using DAL.DomainClass;
using BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.ServiceNV;
using DAL.Context;
using Microsoft.Data.SqlClient;

namespace PRL
{
    public partial class Form_NhanVien : Form
    {
        private NhanVienService _service;
        private int _idWhenClick;

        public Form_NhanVien()
        {
            InitializeComponent();
            _service = new NhanVienService();

        }
        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            LoadTenSanPham();
            LoatIDSanPham();

        }
        public void LoatIDSanPham()
        {
            string search = "";
            List<Sanpham> sanPhamList = _service.GetSPs(search);
            cbo_IDSanPham.DataSource = sanPhamList;
            cbo_IDSanPham.DisplayMember = "Id";
            cbo_IDSanPham.ValueMember = "Id";
            // 
            cbo_IDSanPhamBL.DataSource = sanPhamList;
            cbo_IDSanPhamBL.DisplayMember = "Id";
            cbo_IDSanPhamBL.ValueMember = "Id";

        }
        public void LoadTenSanPham()
        {
            string search = "";
            List<Sanpham> sanPhamList = _service.GetSPs(search);
            cbo_TenSP.DataSource = sanPhamList;
            cbo_TenSP.DisplayMember = "Ten";
            cbo_TenSP.ValueMember = "Id";
            //
            cbo_TenSanPhamBL.DataSource = sanPhamList;
            cbo_TenSanPhamBL.DisplayMember = "Ten";
            cbo_TenSanPhamBL.ValueMember = "Id";

        }

        private void cbo_TenSP_SelectedIndexChanged(object sender, EventArgs e)// gọi sự kiện cho combobox phần tìm kiếm sản phẩm
        {
            // lấy ra giá của sản phẩm 
            Sanpham sanpham = cbo_TenSP.SelectedItem as Sanpham;

            if (sanpham != null)
            {
                txt_GiaSanPham.Text = sanpham.Giatien.ToString();
                cbo_IDSanPham.Text = sanpham.Id.ToString();
            }
            else
            {
                txt_GiaSanPham.Text = "";
                cbo_IDSanPham.Text = "";
            }

        }
        private void cbo_IDSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sanpham sanpham = cbo_IDSanPham.SelectedItem as Sanpham;

            if (sanpham != null)
            {
                txt_GiaSanPham.Text = sanpham.Giatien.ToString();
                cbo_TenSP.Text = sanpham.Ten.ToString();
            }
            else
            {
                txt_GiaSanPham.Text = "";
                cbo_TenSP.Text = "";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var chon = MessageBox.Show("bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel);
            if (chon == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int stt = 1;
            dtg_viewNV.ColumnCount = 6;
            dtg_viewNV.Columns[0].Name = "STT";
            dtg_viewNV.Columns[1].Name = "ID";
            dtg_viewNV.Columns[2].Name = "Ten";
            dtg_viewNV.Columns[3].Name = "Địa Chỉ";
            dtg_viewNV.Columns[4].Name = "SĐT";
            dtg_viewNV.Columns[5].Name = "Email";
            var nv = new NhanVien();
            nv.Ten = txt_TenCaNhan.Text;
            nv.Email = txt_MailCaNhan.Text;

            if (int.TryParse(txt_SDTCaNhan.Text, out int sdt))
            {
                nv.Sdt = sdt;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            nv.Diachi = txt_DiaChiCaNhan.Text;

            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(nv));

                dtg_viewNV.Rows.Add(stt, nv.Id, nv.Ten, nv.Email, nv.Sdt, nv.Diachi);
                stt++;
            }
            else
            {
                return;
            }
        }
        private void btn_TimKiemSP_Click(object sender, EventArgs e)
        {
            string searchId = cbo_IDSanPham.Text.Trim();
            string searchTen = cbo_TenSP.Text.Trim();
            string searchGia = txt_GiaSanPham.Text.Trim();
            List<Sanpham> sanphamList = _service.GetSPs(searchId);
            dtg_viewNV.Rows.Clear();
            int stt = 1;
            dtg_viewNV.ColumnCount = 6;
            dtg_viewNV.Columns[0].Name = "STT";
            dtg_viewNV.Columns[1].Name = "ID";
            dtg_viewNV.Columns[2].Name = "Ten";
            dtg_viewNV.Columns[3].Name = "Mô Tả";
            dtg_viewNV.Columns[4].Name = "Số lượng kho";
            dtg_viewNV.Columns[5].Name = "Giá tền";

            foreach (var sp in sanphamList)
            {
                if ((!string.IsNullOrWhiteSpace(searchId) && searchId == sp.Id.ToString()) ||
                    (!string.IsNullOrWhiteSpace(searchTen) && searchTen == sp.Ten) ||
                    (!string.IsNullOrWhiteSpace(searchGia) && searchGia == sp.Giatien.ToString()))
                {
                    dtg_viewNV.Rows.Add(stt, sp.Id, sp.Ten, sp.Mota, sp.Soluongtonkho, sp.Giatien);
                    stt++;
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.Iddonhang = int.Parse(txt_IDĐonHangBL.Text);
            dh.Id = int.Parse(cbo_IDSanPhamBL.Text);
            dh.Ngayxuatdon = dtp_ngay_in_BL.Value;
            dh.TenSanPham = cbo_TenSanPhamBL.Text;
            dh.SoLuongMua = int.Parse(mud_SoLuongSach.Value.ToString());
            dh.TenNguoiMua = txt_TenNguoiMuaBL.Text;
            dh.Giadh = int.Parse(txt_GiaSanPhamBL.Text);
            dh.Ghichu = txt_GhiChuBL.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm đơn hàng không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                dh.Tinhtrangdh = " Đang Giao";
                MessageBox.Show(_service.Add(dh));              
            }
        }
        //var iddonhang = int.Parse(txt_IDSanPhamBL.Text);

        //// Kiểm tra xem có bất kỳ đơn hàng nào có Iddonhang bằng iddonhang không
        //var existingDonHang = _service.GetDHs().FirstOrDefault(x => x.Iddonhang == iddonhang);

        //if (existingDonHang != null)
        //{
        //    MessageBox.Show($"Đã tồn tại đơn hàng với ID Đơn hàng {iddonhang}. Vui lòng chọn ID khác.");
        //}



        //public void InBienLai()
        //{
        //    var existingOrders = _service.GetDHs("");
        //    // Lấy ID đơn hàng lớn nhất
        //    int maxOrderId = existingOrders.Any() ? existingOrders.Max(d => d.Iddonhang.GetValueOrDefault()) : 0;
        //    int newOrderId = maxOrderId + 1;
        //    txt_IDĐonHangBL.Text = newOrderId.ToString();
        //}

        private void cbo_IDSanPhamBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sanpham sanpham = cbo_IDSanPhamBL.SelectedItem as Sanpham;

            if (sanpham != null)
            {
                txt_GiaSanPhamBL.Text = sanpham.Giatien.ToString();
                cbo_TenSanPhamBL.Text = sanpham.Ten.ToString();
            }
            else
            {
                txt_GiaSanPhamBL.Text = "";
                cbo_TenSanPhamBL.Text = "";
            }
        }

        private void cbo_TenSanPhamBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            var TenSanPham = cbo_TenSanPhamBL.SelectedItem as Sanpham;
            if (TenSanPham != null)
            {
                txt_GiaSanPham.Text = TenSanPham.Giatien.ToString();
                cbo_IDSanPhamBL.Text = TenSanPham.Id.ToString();
            }
            else
            {
                txt_GiaSanPham.Text = "";
                cbo_IDSanPhamBL.Text = "";
            }
        }
        public void TinhTongTien()
        {
            // tính tổng số tiền
            var gia = int.Parse(txt_GiaSanPhamBL.Text);
            var soluong = int.Parse(mud_SoLuongSach.Value.ToString());
            var tinhtong = gia * soluong;
            txt_TongTienBL.Text = tinhtong.ToString();
        }
        private void mud_SoLuongSach_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            var danhsach = _service.GetDHs();
            int stt = 1;
            dtg_viewNV.ColumnCount = 10;
            dtg_viewNV.Columns[0].Name = "STT";
            dtg_viewNV.Columns[1].Name = "ID";
            dtg_viewNV.Columns[2].Name = "ID Đơn Hàng";
            dtg_viewNV.Columns[3].Name = "Ngày Xuất Đơn";
            dtg_viewNV.Columns[4].Name = "Tình Trạng";
            dtg_viewNV.Columns[5].Name = "Tên Sản Phẩm";
            dtg_viewNV.Columns[6].Name = "Số lượng Mua";
            dtg_viewNV.Columns[7].Name = "Tên Người Mua";
            dtg_viewNV.Columns[8].Name = "Giá HĐ";
            dtg_viewNV.Columns[9].Name = "Ghi Chú";
            dtg_viewNV.Rows.Clear();
            foreach (var dh in danhsach)
            {
                dtg_viewNV.Rows.Add(stt++, dh.Iddonhang, dh.Id, dh.Ngayxuatdon, dh.Tinhtrangdh, dh.TenSanPham, dh.SoLuongMua, dh.TenNguoiMua, dh.Giadh, dh.Ghichu);
            }
        }   
    }
}
