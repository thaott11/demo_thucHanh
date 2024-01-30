namespace PRL
{
    partial class Form_NhanVien
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
            dtg_viewNV = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            txt_TenCaNhan = new TextBox();
            txt_MailCaNhan = new TextBox();
            txt_SDTCaNhan = new TextBox();
            button4 = new Button();
            label8 = new Label();
            label9 = new Label();
            txt_DiaChiCaNhan = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txt_NgayXuatDon = new TextBox();
            txt_GiaSanPham = new TextBox();
            txt_TenNguoiMuaBL = new TextBox();
            txt_TongTienBL = new TextBox();
            btn_TimKiemSP = new Button();
            label14 = new Label();
            mud_SoLuongSach = new NumericUpDown();
            label15 = new Label();
            txt_GiaSanPhamBL = new TextBox();
            label16 = new Label();
            txt_GhiChuBL = new TextBox();
            label17 = new Label();
            cbo_TenSP = new ComboBox();
            cbo_TenSanPhamBL = new ComboBox();
            cbo_IDSanPhamBL = new ComboBox();
            dtp_ngay_in_BL = new DateTimePicker();
            cbo_IDSanPham = new ComboBox();
            txt_IDĐonHangBL = new TextBox();
            label18 = new Label();
            btn_Show = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_viewNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mud_SoLuongSach).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 123);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 0;
            label1.Text = "Cập Nhập Thông Tin Cá Nhân";
            // 
            // dtg_viewNV
            // 
            dtg_viewNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_viewNV.Location = new Point(12, 339);
            dtg_viewNV.Name = "dtg_viewNV";
            dtg_viewNV.RowTemplate.Height = 25;
            dtg_viewNV.Size = new Size(776, 147);
            dtg_viewNV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên Sản Phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 129);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Số Lượng Mua";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 159);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 0;
            label5.Text = "Tên Người Mua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 246);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 0;
            label6.Text = "Tổng Số Tiền";
            // 
            // button2
            // 
            button2.Location = new Point(171, 272);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 2;
            button2.Text = "In Biên Lai";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(427, 286);
            button3.Name = "button3";
            button3.Size = new Size(299, 23);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 144);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 0;
            label7.Text = "Tên:";
            // 
            // txt_TenCaNhan
            // 
            txt_TenCaNhan.Location = new Point(478, 141);
            txt_TenCaNhan.Name = "txt_TenCaNhan";
            txt_TenCaNhan.Size = new Size(195, 23);
            txt_TenCaNhan.TabIndex = 1;
            // 
            // txt_MailCaNhan
            // 
            txt_MailCaNhan.Location = new Point(478, 170);
            txt_MailCaNhan.Name = "txt_MailCaNhan";
            txt_MailCaNhan.Size = new Size(195, 23);
            txt_MailCaNhan.TabIndex = 1;
            // 
            // txt_SDTCaNhan
            // 
            txt_SDTCaNhan.Location = new Point(478, 199);
            txt_SDTCaNhan.Name = "txt_SDTCaNhan";
            txt_SDTCaNhan.Size = new Size(195, 23);
            txt_SDTCaNhan.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(502, 257);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 2;
            button4.Text = "Cập Nhập Thông Tin ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 202);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 0;
            label8.Text = "SĐT:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(424, 231);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Đia Chỉ:";
            // 
            // txt_DiaChiCaNhan
            // 
            txt_DiaChiCaNhan.Location = new Point(478, 228);
            txt_DiaChiCaNhan.Name = "txt_DiaChiCaNhan";
            txt_DiaChiCaNhan.Size = new Size(195, 23);
            txt_DiaChiCaNhan.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(433, 173);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 0;
            label10.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(392, 67);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 0;
            label11.Text = "Giá Sản Phẩm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(398, 9);
            label12.Name = "label12";
            label12.Size = new Size(74, 15);
            label12.TabIndex = 0;
            label12.Text = "ID Sản Phẩm";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 72);
            label13.Name = "label13";
            label13.Size = new Size(92, 15);
            label13.TabIndex = 0;
            label13.Text = "Ngày In Biên Lai";
            // 
            // txt_NgayXuatDon
            // 
            txt_NgayXuatDon.Location = new Point(117, 216);
            txt_NgayXuatDon.Name = "txt_NgayXuatDon";
            txt_NgayXuatDon.Size = new Size(185, 23);
            txt_NgayXuatDon.TabIndex = 1;
            // 
            // txt_GiaSanPham
            // 
            txt_GiaSanPham.Location = new Point(478, 64);
            txt_GiaSanPham.Name = "txt_GiaSanPham";
            txt_GiaSanPham.Size = new Size(195, 23);
            txt_GiaSanPham.TabIndex = 5;
            // 
            // txt_TenNguoiMuaBL
            // 
            txt_TenNguoiMuaBL.Location = new Point(148, 156);
            txt_TenNguoiMuaBL.Name = "txt_TenNguoiMuaBL";
            txt_TenNguoiMuaBL.Size = new Size(185, 23);
            txt_TenNguoiMuaBL.TabIndex = 7;
            // 
            // txt_TongTienBL
            // 
            txt_TongTienBL.Location = new Point(148, 243);
            txt_TongTienBL.Name = "txt_TongTienBL";
            txt_TongTienBL.Size = new Size(185, 23);
            txt_TongTienBL.TabIndex = 8;
            // 
            // btn_TimKiemSP
            // 
            btn_TimKiemSP.Location = new Point(502, 93);
            btn_TimKiemSP.Name = "btn_TimKiemSP";
            btn_TimKiemSP.Size = new Size(150, 23);
            btn_TimKiemSP.TabIndex = 10;
            btn_TimKiemSP.Text = "Tìm Kiếm Sản Phẩm";
            btn_TimKiemSP.UseVisualStyleBackColor = true;
            btn_TimKiemSP.Click += btn_TimKiemSP_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(55, 106);
            label14.Name = "label14";
            label14.Size = new Size(81, 15);
            label14.TabIndex = 0;
            label14.Text = "Tên Sản Phẩm";
            // 
            // mud_SoLuongSach
            // 
            mud_SoLuongSach.Location = new Point(148, 127);
            mud_SoLuongSach.Name = "mud_SoLuongSach";
            mud_SoLuongSach.Size = new Size(185, 23);
            mud_SoLuongSach.TabIndex = 15;
            mud_SoLuongSach.ValueChanged += mud_SoLuongSach_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(62, 15);
            label15.Name = "label15";
            label15.Size = new Size(74, 15);
            label15.TabIndex = 0;
            label15.Text = "ID Sản Phẩm";
            // 
            // txt_GiaSanPhamBL
            // 
            txt_GiaSanPhamBL.Location = new Point(150, 184);
            txt_GiaSanPhamBL.Name = "txt_GiaSanPhamBL";
            txt_GiaSanPhamBL.Size = new Size(183, 23);
            txt_GiaSanPhamBL.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(56, 187);
            label16.Name = "label16";
            label16.Size = new Size(80, 15);
            label16.TabIndex = 0;
            label16.Text = "Giá Sản Phẩm";
            // 
            // txt_GhiChuBL
            // 
            txt_GhiChuBL.Location = new Point(148, 214);
            txt_GhiChuBL.Name = "txt_GhiChuBL";
            txt_GhiChuBL.Size = new Size(185, 23);
            txt_GhiChuBL.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(91, 217);
            label17.Name = "label17";
            label17.Size = new Size(48, 15);
            label17.TabIndex = 0;
            label17.Text = "Ghi chú";
            // 
            // cbo_TenSP
            // 
            cbo_TenSP.FormattingEnabled = true;
            cbo_TenSP.Location = new Point(478, 35);
            cbo_TenSP.Name = "cbo_TenSP";
            cbo_TenSP.Size = new Size(195, 23);
            cbo_TenSP.TabIndex = 19;
            cbo_TenSP.SelectedIndexChanged += cbo_TenSP_SelectedIndexChanged;
            // 
            // cbo_TenSanPhamBL
            // 
            cbo_TenSanPhamBL.FormattingEnabled = true;
            cbo_TenSanPhamBL.Location = new Point(149, 98);
            cbo_TenSanPhamBL.Name = "cbo_TenSanPhamBL";
            cbo_TenSanPhamBL.Size = new Size(182, 23);
            cbo_TenSanPhamBL.TabIndex = 20;
            cbo_TenSanPhamBL.SelectedIndexChanged += cbo_TenSanPhamBL_SelectedIndexChanged;
            // 
            // cbo_IDSanPhamBL
            // 
            cbo_IDSanPhamBL.FormattingEnabled = true;
            cbo_IDSanPhamBL.Location = new Point(147, 12);
            cbo_IDSanPhamBL.Name = "cbo_IDSanPhamBL";
            cbo_IDSanPhamBL.Size = new Size(183, 23);
            cbo_IDSanPhamBL.TabIndex = 21;
            cbo_IDSanPhamBL.SelectedIndexChanged += cbo_IDSanPhamBL_SelectedIndexChanged;
            // 
            // dtp_ngay_in_BL
            // 
            dtp_ngay_in_BL.Location = new Point(148, 70);
            dtp_ngay_in_BL.Name = "dtp_ngay_in_BL";
            dtp_ngay_in_BL.Size = new Size(182, 23);
            dtp_ngay_in_BL.TabIndex = 22;
            // 
            // cbo_IDSanPham
            // 
            cbo_IDSanPham.FormattingEnabled = true;
            cbo_IDSanPham.Location = new Point(478, 7);
            cbo_IDSanPham.Name = "cbo_IDSanPham";
            cbo_IDSanPham.Size = new Size(195, 23);
            cbo_IDSanPham.TabIndex = 23;
            cbo_IDSanPham.SelectedIndexChanged += cbo_IDSanPham_SelectedIndexChanged;
            // 
            // txt_IDĐonHangBL
            // 
            txt_IDĐonHangBL.Location = new Point(147, 40);
            txt_IDĐonHangBL.Name = "txt_IDĐonHangBL";
            txt_IDĐonHangBL.Size = new Size(183, 23);
            txt_IDĐonHangBL.TabIndex = 24;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(61, 43);
            label18.Name = "label18";
            label18.Size = new Size(75, 15);
            label18.TabIndex = 0;
            label18.Text = "ID Đơn Hàng";
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(171, 301);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(150, 23);
            btn_Show.TabIndex = 25;
            btn_Show.Text = "Show Đơn Hàng";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(btn_Show);
            Controls.Add(txt_IDĐonHangBL);
            Controls.Add(cbo_IDSanPham);
            Controls.Add(dtp_ngay_in_BL);
            Controls.Add(cbo_IDSanPhamBL);
            Controls.Add(cbo_TenSanPhamBL);
            Controls.Add(cbo_TenSP);
            Controls.Add(txt_GhiChuBL);
            Controls.Add(txt_GiaSanPhamBL);
            Controls.Add(mud_SoLuongSach);
            Controls.Add(btn_TimKiemSP);
            Controls.Add(txt_TongTienBL);
            Controls.Add(txt_TenNguoiMuaBL);
            Controls.Add(txt_GiaSanPham);
            Controls.Add(dtg_viewNV);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(txt_DiaChiCaNhan);
            Controls.Add(txt_SDTCaNhan);
            Controls.Add(txt_MailCaNhan);
            Controls.Add(txt_TenCaNhan);
            Controls.Add(label13);
            Controls.Add(label17);
            Controls.Add(label6);
            Controls.Add(label14);
            Controls.Add(label5);
            Controls.Add(label18);
            Controls.Add(label15);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label12);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_NhanVien";
            Text = "form_NhanVien";
            Load += Form_NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_viewNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)mud_SoLuongSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtg_viewNV;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_TenNguoiMuaBL;
        private TextBox txt_TongTienBL;
        private TextBox textBox5;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox txt_TenCaNhan;
        private TextBox txt_MailCaNhan;
        private TextBox txt_SDTCaNhan;
        private Button button4;
        private Label label8;
        private Label label9;
        private TextBox txt_DiaChiCaNhan;
        private Button button6;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txt_NgayXuatDon;
        private TextBox txt_GiaSanPham;
        private Button btn_TimKiemSP;
        private TextBox txt_TenSanPhamBL;
        private Label label14;
        private NumericUpDown mud_SoLuongSach;
        private TextBox txt_IDSanPhamBL;
        private Label label15;
        private TextBox txt_GiaSanPhamBL;
        private Label label16;
        private TextBox txt_GhiChuBL;
        private Label label17;
        private ComboBox cbo_TenSP;
        private ComboBox cbo_TenSanPhamBL;
        private ComboBox cbo_IDSanPhamBL;
        private DateTimePicker dtp_ngay_in_BL;
        private ComboBox cbo_IDSanPham;
        private TextBox txt_IDĐonHangBL;
        private Label label18;
        private Button btn_Show;
    }
}