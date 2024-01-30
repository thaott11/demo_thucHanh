namespace PRL.Forms
{
    partial class Form_Trang_DN
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
            btn_Admin = new Button();
            btn_KhachHang = new Button();
            btn_NhanVien = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font(".VnArial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 23);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Form Đăng Nhập";
            // 
            // btn_Admin
            // 
            btn_Admin.Location = new Point(43, 100);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(187, 50);
            btn_Admin.TabIndex = 1;
            btn_Admin.Text = "Admin";
            btn_Admin.UseVisualStyleBackColor = true;
            btn_Admin.Click += btn_Admin_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Location = new Point(520, 100);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(187, 50);
            btn_KhachHang.TabIndex = 2;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.UseVisualStyleBackColor = true;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.Location = new Point(288, 100);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Size = new Size(187, 50);
            btn_NhanVien.TabIndex = 3;
            btn_NhanVien.Text = "Nhân Viên";
            btn_NhanVien.UseVisualStyleBackColor = true;
            btn_NhanVien.Click += btn_NhanVien_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(209, 219);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(353, 46);
            btn_Thoat.TabIndex = 4;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // Form_Trang_Đang_Nhapcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_NhanVien);
            Controls.Add(btn_KhachHang);
            Controls.Add(btn_Admin);
            Controls.Add(label1);
            Name = "Form_Trang_Đang_Nhapcs";
            Text = "Form_Trang_Đang_Nhapcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Admin;
        private Button btn_KhachHang;
        private Button btn_NhanVien;
        private Button btn_Thoat;
    }
}