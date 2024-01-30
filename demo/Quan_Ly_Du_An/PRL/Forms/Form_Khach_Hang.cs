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

namespace PRL
{
    public partial class Form_Khach_Hang : Form
    {
        private KhachHangService _Service;
        private int _idwhenClick;
        private int IdDH;
        public Form_Khach_Hang()
        {
            InitializeComponent();
            _Service = new KhachHangService();


        }

        private void Form_Khach_Hang_Load(object sender, EventArgs e)
        {
            LoatSanPham();
            IdDonHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchId = txt_TimKiemId.Text.Trim();
            string searchTen = txt_TimKiemTen.Text.Trim();
            string searchGia = txt_TimkiemGia.Text.Trim();
            List<Sanpham> sanphamList = _Service.GetSP(searchId);
            dtg_view.Rows.Clear();
            int stt = 1;
            dtg_view.ColumnCount = 6;
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID";
            dtg_view.Columns[2].Name = "Ten";
            dtg_view.Columns[3].Name = "Mô Tả";
            dtg_view.Columns[4].Name = "Số lượng kho";
            dtg_view.Columns[5].Name = "Giá tền";

            foreach (var sp in sanphamList)
            {
                if ((!string.IsNullOrWhiteSpace(searchId) && searchId == sp.Id.ToString()) ||
                    (!string.IsNullOrWhiteSpace(searchTen) && searchTen == sp.Ten) ||
                    (!string.IsNullOrWhiteSpace(searchGia) && searchGia == sp.Giatien.ToString()))
                {
                    dtg_view.Rows.Add(stt, sp.Id, sp.Ten, sp.Mota, sp.Soluongtonkho, sp.Giatien);
                    stt++;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Sản Phẩm nào");
                }
            }
        }
        public void LoatSanPham()
        {
            string search = "";
            List<Sanpham> sanPhamList = _Service.GetSP(search);
            cbo_IDSPDatMua.DataSource = sanPhamList;
            cbo_IDSPDatMua.DisplayMember = "Id";
            cbo_IDSPDatMua.ValueMember = "Id";

        }
        private void cbo_IDSPDatMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sanpham sanpham = cbo_IDSPDatMua.SelectedItem as Sanpham;

            if (sanpham != null)
            {
                txt_GiaDonHang.Text = sanpham.Giatien.ToString();
                txt_TenSPDatMua.Text = sanpham.Ten.ToString();

            }
            else
            {
                txt_GiaDonHang.Text = "";
                txt_TenSPDatMua.Text = "";
            }
        }
        public void TinhTongTien()
        {
            var gia = int.Parse(txt_GiaDonHang.Text);
            var soluong = int.Parse(mud_SoLuongMua.Value.ToString());
            var tinhtong = gia * soluong;
            txt_GiaDonHang.Text = tinhtong.ToString();
        }
        private void mud_SoLuongMua_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btn_thongTinCN_Click(object sender, EventArgs e)
        {

            var kh = new KhachHang();
            kh.Id = _idwhenClick;
            kh.TenKhachHang = txt_TenKhachHang.Text;
            kh.DiaChi = txt_DiaChi.Text;
            if (int.TryParse(txt_SoDienThoai.Text, out int sdt))
            {
                kh.DienThoai = sdt;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;
            }

            kh.DanhGia = txt_GhiChu.Text;

            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_Service.Update(kh));

                dtg_view.Rows.Add(kh.Id, kh.TenKhachHang, kh.DiaChi, kh.DienThoai, kh.DanhGia);

            }
            else
            {
                return;
            }
        }

        private void btn_ThongTinDH_Click(object sender, EventArgs e)
        {
            string searchId = txt_IDDonHangTT.Text.Trim();
            string searchTen = txt_TenDonHangTT.Text.Trim();
            List<DonHang> donhangList = _Service.GetDH(searchId);
            dtg_view.Rows.Clear();
            int stt = 1;
            // xac dinh, dtg se co bnh cot         
            dtg_view.ColumnCount = 10;
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID Sản Phẩm";
            dtg_view.Columns[2].Name = "ID Đơn Hàng";
            dtg_view.Columns[3].Name = "Ngày Xuất Đơn";
            dtg_view.Columns[4].Name = "Tình Trạng";
            dtg_view.Columns[5].Name = "Tên Sản Phẩm";
            dtg_view.Columns[6].Name = "Số lượng Mua";
            dtg_view.Columns[7].Name = "Tên Người Mua";
            dtg_view.Columns[8].Name = "Giá HĐ";
            dtg_view.Columns[9].Name = "Ghi Chú";

            foreach (var dh in donhangList)
            {
                if ((!string.IsNullOrWhiteSpace(searchId) && searchId == dh.Id.ToString()) ||
                    (!string.IsNullOrWhiteSpace(searchTen) && searchTen == dh.TenSanPham))

                {
                    dtg_view.Rows.Add(stt++, dh.Id, dh.Iddonhang, dh.Ngayxuatdon, dh.Tinhtrangdh, dh.TenSanPham, dh.SoLuongMua, dh.TenNguoiMua, dh.Giadh, dh.Ghichu);
                    stt++;
                }

                else
                {
                    MessageBox.Show("Không tìm thấy Sản Phẩm nào");
                }
            }
        }

        private void btn_ThongTinSP_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_view.ColumnCount = 6;
            //dat ten cot
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "ID";
            dtg_view.Columns[2].Name = "Ten";
            dtg_view.Columns[3].Name = "Mô Tả";
            dtg_view.Columns[4].Name = "Số lượng kho";
            dtg_view.Columns[5].Name = "Giá tền";
            dtg_view.Rows.Clear();
            foreach (var sp in _Service.GetSP(txt_TenSPDatMua.Text))
            {
                dtg_view.Rows.Add(stt++, sp.Id, sp.Ten, sp.Mota, sp.Soluongtonkho, sp.Giatien);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DatMua_Click(object sender, EventArgs e)
        {
            DonHang dh = new DonHang();
            dh.Iddonhang = int.Parse(txt_IDDonHang.Text);
            dh.Id = int.Parse(cbo_IDSPDatMua.Text);
            dh.Ngayxuatdon = dtp_NgayMua.Value;
            dh.TenSanPham = txt_TenSPDatMua.Text;
            dh.SoLuongMua = int.Parse(mud_SoLuongMua.Value.ToString());
            dh.TenNguoiMua = txt_TenNguoiMua.Text;
            dh.Giadh = int.Parse(txt_GiaDonHang.Text);
            dh.Ghichu = txt_GhiChuDM.Text;
            var option = MessageBox.Show("Xác nhận muốn thêm đơn hàng không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                dh.Tinhtrangdh = " Đang Giao";
                MessageBox.Show(_Service.Add(dh));
                dtg_view.Rows.Add(dh.Id, dh.Iddonhang, dh.Ngayxuatdon, dh.Tinhtrangdh, dh.TenSanPham, dh.SoLuongMua, dh.TenNguoiMua, dh.Giadh, dh.Ghichu);

            }
        }
        // lấy id đơn hàng
        public void IdDonHang()
        {
            var existingOrders = _Service.GetDH("");

            // Lấy ID đơn hàng lớn nhất
            int maxOrderId = existingOrders.Any() ? existingOrders.Max(d => d.Iddonhang.GetValueOrDefault()) : 0;
            int newOrderId = maxOrderId + 1;
            txt_IDDonHang.Text = newOrderId.ToString();
        }
    }
}
