namespace PRL
{
    partial class Form_Khach_Hang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_TimKiemSanPham = new Button();
            txt_TimkiemGia = new TextBox();
            dtg_view = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            btn_DatMua = new Button();
            btn_ThongTinSP = new Button();
            btn_ThongTinDH = new Button();
            cbo_IDSPDatMua = new ComboBox();
            btn_Thoat = new Button();
            txt_TimKiemTen = new TextBox();
            txt_TimKiemId = new TextBox();
            btn_thongTinCN = new Button();
            txt_TenDonHangTT = new TextBox();
            txt_IDDonHangTT = new TextBox();
            txt_GiaDonHang = new TextBox();
            txt_TenSPDatMua = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            dtp_NgayMua = new DateTimePicker();
            txt_TenNguoiMua = new TextBox();
            label13 = new Label();
            mud_SoLuongMua = new NumericUpDown();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txt_IDKhachHang = new TextBox();
            txt_TenKhachHang = new TextBox();
            txt_DiaChi = new TextBox();
            txt_GhiChu = new TextBox();
            txt_SoDienThoai = new TextBox();
            txt_IDDonHang = new TextBox();
            label18 = new Label();
            txt_GhiChuDM = new TextBox();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_view).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mud_SoLuongMua).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btn_TimKiemSanPham
            // 
            btn_TimKiemSanPham.Location = new Point(117, 101);
            btn_TimKiemSanPham.Name = "btn_TimKiemSanPham";
            btn_TimKiemSanPham.Size = new Size(166, 23);
            btn_TimKiemSanPham.TabIndex = 1;
            btn_TimKiemSanPham.Text = "Tìm Kiếm Sản Phẩm";
            btn_TimKiemSanPham.UseVisualStyleBackColor = true;
            btn_TimKiemSanPham.Click += button1_Click;
            // 
            // txt_TimkiemGia
            // 
            txt_TimkiemGia.Location = new Point(94, 12);
            txt_TimkiemGia.Name = "txt_TimkiemGia";
            txt_TimkiemGia.Size = new Size(214, 23);
            txt_TimkiemGia.TabIndex = 2;
            // 
            // dtg_view
            // 
            dtg_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_view.Location = new Point(16, 414);
            dtg_view.Name = "dtg_view";
            dtg_view.RowTemplate.Height = 25;
            dtg_view.Size = new Size(776, 141);
            dtg_view.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 248);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 0;
            label2.Text = "Số Lượng Mua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 46);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 0;
            label3.Text = "Tìm Theo tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 0;
            label4.Text = "Tìm Theo Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 167);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 0;
            label5.Text = "ID Sản Phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 75);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 0;
            label6.Text = "Tìm theo ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 133);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 0;
            label7.Text = "Tên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 191);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 0;
            label8.Text = "SĐT:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 162);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 0;
            label10.Text = "Địa Chỉ:";
            // 
            // btn_DatMua
            // 
            btn_DatMua.Location = new Point(117, 371);
            btn_DatMua.Name = "btn_DatMua";
            btn_DatMua.Size = new Size(166, 23);
            btn_DatMua.TabIndex = 1;
            btn_DatMua.Text = "Đặt Mua";
            btn_DatMua.UseVisualStyleBackColor = true;
            btn_DatMua.Click += btn_DatMua_Click;
            // 
            // btn_ThongTinSP
            // 
            btn_ThongTinSP.Location = new Point(484, 286);
            btn_ThongTinSP.Name = "btn_ThongTinSP";
            btn_ThongTinSP.Size = new Size(166, 23);
            btn_ThongTinSP.TabIndex = 1;
            btn_ThongTinSP.Text = "Xem Thông tin Sản Phẩm";
            btn_ThongTinSP.UseVisualStyleBackColor = true;
            btn_ThongTinSP.Click += btn_ThongTinSP_Click;
            // 
            // btn_ThongTinDH
            // 
            btn_ThongTinDH.Location = new Point(484, 73);
            btn_ThongTinDH.Name = "btn_ThongTinDH";
            btn_ThongTinDH.Size = new Size(166, 23);
            btn_ThongTinDH.TabIndex = 1;
            btn_ThongTinDH.Text = "Thông Tin Đơn Hàng";
            btn_ThongTinDH.UseVisualStyleBackColor = true;
            btn_ThongTinDH.Click += btn_ThongTinDH_Click;
            // 
            // cbo_IDSPDatMua
            // 
            cbo_IDSPDatMua.FormattingEnabled = true;
            cbo_IDSPDatMua.Items.AddRange(new object[] { "Theo Giá", "100.000VNĐ", "200.000VNĐ", "300.000VNĐ", "400.000VNĐ", "500.000VNĐ" });
            cbo_IDSPDatMua.Location = new Point(96, 159);
            cbo_IDSPDatMua.Name = "cbo_IDSPDatMua";
            cbo_IDSPDatMua.Size = new Size(215, 23);
            cbo_IDSPDatMua.TabIndex = 4;
            cbo_IDSPDatMua.SelectedIndexChanged += cbo_IDSPDatMua_SelectedIndexChanged;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(437, 340);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(263, 23);
            btn_Thoat.TabIndex = 1;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // txt_TimKiemTen
            // 
            txt_TimKiemTen.Location = new Point(94, 43);
            txt_TimKiemTen.Name = "txt_TimKiemTen";
            txt_TimKiemTen.Size = new Size(214, 23);
            txt_TimKiemTen.TabIndex = 5;
            // 
            // txt_TimKiemId
            // 
            txt_TimKiemId.Location = new Point(94, 72);
            txt_TimKiemId.Name = "txt_TimKiemId";
            txt_TimKiemId.Size = new Size(214, 23);
            txt_TimKiemId.TabIndex = 6;
            // 
            // btn_thongTinCN
            // 
            btn_thongTinCN.Location = new Point(484, 246);
            btn_thongTinCN.Name = "btn_thongTinCN";
            btn_thongTinCN.Size = new Size(166, 23);
            btn_thongTinCN.TabIndex = 7;
            btn_thongTinCN.Text = "Thông Tin Cá Nhân";
            btn_thongTinCN.UseVisualStyleBackColor = true;
            btn_thongTinCN.Click += btn_thongTinCN_Click;
            // 
            // txt_TenDonHangTT
            // 
            txt_TenDonHangTT.Location = new Point(456, 44);
            txt_TenDonHangTT.Name = "txt_TenDonHangTT";
            txt_TenDonHangTT.Size = new Size(214, 23);
            txt_TenDonHangTT.TabIndex = 8;
            // 
            // txt_IDDonHangTT
            // 
            txt_IDDonHangTT.Location = new Point(456, 15);
            txt_IDDonHangTT.Name = "txt_IDDonHangTT";
            txt_IDDonHangTT.Size = new Size(214, 23);
            txt_IDDonHangTT.TabIndex = 9;
            // 
            // txt_GiaDonHang
            // 
            txt_GiaDonHang.Location = new Point(95, 304);
            txt_GiaDonHang.Name = "txt_GiaDonHang";
            txt_GiaDonHang.Size = new Size(214, 23);
            txt_GiaDonHang.TabIndex = 10;
            // 
            // txt_TenSPDatMua
            // 
            txt_TenSPDatMua.Location = new Point(94, 217);
            txt_TenSPDatMua.Name = "txt_TenSPDatMua";
            txt_TenSPDatMua.Size = new Size(215, 23);
            txt_TenSPDatMua.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 191);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 0;
            label9.Text = "Ngày Mua";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 220);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 0;
            label11.Text = "Tên Sản Phẩm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 307);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 0;
            label12.Text = "Giá Đơn Hàng";
            // 
            // dtp_NgayMua
            // 
            dtp_NgayMua.Location = new Point(96, 188);
            dtp_NgayMua.Name = "dtp_NgayMua";
            dtp_NgayMua.Size = new Size(214, 23);
            dtp_NgayMua.TabIndex = 12;
            // 
            // txt_TenNguoiMua
            // 
            txt_TenNguoiMua.Location = new Point(94, 275);
            txt_TenNguoiMua.Name = "txt_TenNguoiMua";
            txt_TenNguoiMua.Size = new Size(215, 23);
            txt_TenNguoiMua.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(-1, 278);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 0;
            label13.Text = "Tên Người Mua";
            // 
            // mud_SoLuongMua
            // 
            mud_SoLuongMua.Location = new Point(95, 246);
            mud_SoLuongMua.Name = "mud_SoLuongMua";
            mud_SoLuongMua.Size = new Size(215, 23);
            mud_SoLuongMua.TabIndex = 14;
            mud_SoLuongMua.Value = new decimal(new int[] { 1, 0, 0, 0 });
            mud_SoLuongMua.ValueChanged += mud_SoLuongMua_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(375, 20);
            label14.Name = "label14";
            label14.Size = new Size(75, 15);
            label14.TabIndex = 0;
            label14.Text = "ID Đơn Hàng";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(368, 47);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 0;
            label15.Text = "Tên Đơn Hàng";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(361, 105);
            label16.Name = "label16";
            label16.Size = new Size(89, 15);
            label16.TabIndex = 0;
            label16.Text = "ID Khách Hàng:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(397, 220);
            label17.Name = "label17";
            label17.Size = new Size(53, 15);
            label17.TabIndex = 0;
            label17.Text = "Ghi Chú:";
            // 
            // txt_IDKhachHang
            // 
            txt_IDKhachHang.Location = new Point(456, 102);
            txt_IDKhachHang.Name = "txt_IDKhachHang";
            txt_IDKhachHang.Size = new Size(214, 23);
            txt_IDKhachHang.TabIndex = 15;
            // 
            // txt_TenKhachHang
            // 
            txt_TenKhachHang.Location = new Point(456, 130);
            txt_TenKhachHang.Name = "txt_TenKhachHang";
            txt_TenKhachHang.Size = new Size(214, 23);
            txt_TenKhachHang.TabIndex = 16;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(456, 159);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(214, 23);
            txt_DiaChi.TabIndex = 17;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(456, 217);
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(214, 23);
            txt_GhiChu.TabIndex = 18;
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.Location = new Point(456, 188);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(214, 23);
            txt_SoDienThoai.TabIndex = 19;
            // 
            // txt_IDDonHang
            // 
            txt_IDDonHang.Location = new Point(96, 130);
            txt_IDDonHang.Name = "txt_IDDonHang";
            txt_IDDonHang.Size = new Size(215, 23);
            txt_IDDonHang.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 133);
            label18.Name = "label18";
            label18.Size = new Size(75, 15);
            label18.TabIndex = 0;
            label18.Text = "ID Đơn Hàng";
            // 
            // txt_GhiChuDM
            // 
            txt_GhiChuDM.Location = new Point(96, 333);
            txt_GhiChuDM.Name = "txt_GhiChuDM";
            txt_GhiChuDM.Size = new Size(212, 23);
            txt_GhiChuDM.TabIndex = 21;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 336);
            label19.Name = "label19";
            label19.Size = new Size(50, 15);
            label19.TabIndex = 0;
            label19.Text = "Ghi Chú";
            // 
            // Form_Khach_Hang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(txt_GhiChuDM);
            Controls.Add(txt_IDDonHang);
            Controls.Add(txt_SoDienThoai);
            Controls.Add(txt_GhiChu);
            Controls.Add(txt_DiaChi);
            Controls.Add(txt_TenKhachHang);
            Controls.Add(txt_IDKhachHang);
            Controls.Add(mud_SoLuongMua);
            Controls.Add(txt_TenNguoiMua);
            Controls.Add(dtp_NgayMua);
            Controls.Add(txt_TenSPDatMua);
            Controls.Add(txt_GiaDonHang);
            Controls.Add(txt_IDDonHangTT);
            Controls.Add(txt_TenDonHangTT);
            Controls.Add(btn_thongTinCN);
            Controls.Add(txt_TimKiemId);
            Controls.Add(txt_TimKiemTen);
            Controls.Add(cbo_IDSPDatMua);
            Controls.Add(dtg_view);
            Controls.Add(txt_TimkiemGia);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_ThongTinDH);
            Controls.Add(btn_ThongTinSP);
            Controls.Add(btn_DatMua);
            Controls.Add(btn_TimKiemSanPham);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label18);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label19);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Khach_Hang";
            Text = "Form_Khach_Hang";
            Load += Form_Khach_Hang_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_view).EndInit();
            ((System.ComponentModel.ISupportInitialize)mud_SoLuongMua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_TimKiemSanPham;
        private TextBox txt_TimkiemGia;
        private DataGridView dtg_view;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button btn_DatMua;
        private Button btn_ThongTinSP;
        private Button btn_ThongTinDH;
        private ComboBox cbo_IDSPDatMua;
        private Button btn_Thoat;
        private TextBox txt_TimKiemTen;
        private TextBox txt_TimKiemId;
        private Button btn_thongTinCN;
        private TextBox txt_TenDonHangTT;
        private TextBox txt_IDDonHangTT;
        private TextBox txt_GiaDonHang;
        private TextBox txt_TenSPDatMua;
        private Label label9;
        private Label label11;
        private Label label12;
        private DateTimePicker dtp_NgayMua;
        private TextBox txt_TenNguoiMua;
        private Label label13;
        private NumericUpDown mud_SoLuongMua;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txt_IDKhachHang;
        private TextBox txt_TenKhachHang;
        private TextBox txt_DiaChi;
        private TextBox txt_GhiChu;
        private TextBox txt_SoDienThoai;
        private TextBox txt_IDDonHang;
        private Label label18;
        private TextBox txt_GhiChuDM;
        private Label label19;
    }
}