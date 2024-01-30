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
    public partial class Form1 : Form
    {
        private SinhVienService _service;
        private int _idWhenClick;
        public Form1()
        {
            InitializeComponent();
            _service = new SinhVienService();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Tạo ông nhõi nào đó
            var sv = new Sinhvien();
            sv.Ten = txt_Ten.Text;
            sv.Email = txt_Email.Text;
            sv.Sdt = txt_Sdt.Text;
            sv.Diachi = txt_DiaChi.Text;
            sv.IdPh = int.Parse(txt_PhuHuynh.Text);
            var option = MessageBox.Show("Xác nhận muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(sv));
            }
            else
            {
                return;
            }
            
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            //khai báo stt
            int stt = 1;
            // số cột cần có
            dtgView.ColumnCount = 6;
            //đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "ID";
            dtgView.Columns[2].Name = "Tên";
            dtgView.Columns[3].Name = "Địa chỉ";
            dtgView.Columns[4].Name = "SDT";
            dtgView.Columns[5].Name = "Email";
            //ẩn cột ID đi
            dtgView.Columns[1].Visible = false;
            //Xóa dòng mỗi lần load
            dtgView.Rows.Clear();
            foreach (var sv in _service.GetSVs(txt_Ten.Text))
            {
                dtgView.Rows.Add(stt++, sv.Id, sv.Ten, sv.Diachi, sv.Sdt, sv.Email);
            }
        }

        private void dtgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // xác định dòng đang bấm vào nhờ event
            int rowindex = e.RowIndex;
            //lấy id từ dòng đang bấm kết hợp cell
            _idWhenClick = int.Parse(dtgView.Rows[rowindex].Cells[1].Value.ToString());
            //gán giá trị vào txtbox
            var sv = _service.GetSVs(null).FirstOrDefault(x => x.Id == _idWhenClick);
            txt_Ten.Text = sv.Ten;
            txt_DiaChi.Text = sv.Diachi;
            txt_Email.Text = sv.Email;
            txt_Sdt.Text = sv.Sdt;
            txt_PhuHuynh.Text = sv.IdPh.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //Tạo ông nhõi nào đó
            var sv = new Sinhvien();
            //gán sv.Id = id đang chọn
            sv.Id = _idWhenClick;
            sv.Ten = txt_Ten.Text;
            sv.Email = txt_Email.Text;
            sv.Sdt = txt_Sdt.Text;
            sv.Diachi = txt_DiaChi.Text;
            sv.IdPh = int.Parse(txt_PhuHuynh.Text);
            //--0.5 điểm--------
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(sv));
            }
            else
            {
                return;
            }
            //-------------------
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //Tạo ông nhõi nào đó
            var sv = new Sinhvien();
            //gán sv.Id = id đang chọn
            sv.Id = _idWhenClick;
            //--0.5 điểm--------
            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(sv));
            }
            else
            {
                return;
            }
            //-------------------
        }
    }
}
