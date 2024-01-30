namespace PRL.Forms
{
    partial class Form_ĐangNhap_NV
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
            label2 = new Label();
            label3 = new Label();
            txt_TaiKhoan = new TextBox();
            txt_MatKhau = new TextBox();
            btn_login = new Button();
            btn_Thoat = new Button();
            btn_Quaylai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 37);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 87);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 140);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(206, 84);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(329, 23);
            txt_TaiKhoan.TabIndex = 5;
            txt_TaiKhoan.UseSystemPasswordChar = true;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(206, 140);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(329, 23);
            txt_MatKhau.TabIndex = 6;
            txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(300, 251);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(159, 47);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(67, 251);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(159, 47);
            btn_Thoat.TabIndex = 8;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Quaylai
            // 
            btn_Quaylai.Location = new Point(532, 251);
            btn_Quaylai.Name = "btn_Quaylai";
            btn_Quaylai.Size = new Size(159, 47);
            btn_Quaylai.TabIndex = 9;
            btn_Quaylai.Text = "Quay Lại";
            btn_Quaylai.UseVisualStyleBackColor = true;
            btn_Quaylai.Click += btn_Quaylai_Click;
            // 
            // Form_ĐangNhap_NV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Quaylai);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_login);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TaiKhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_ĐangNhap_NV";
            Text = "Form_ĐangNhap_NV";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_TaiKhoan;
        private TextBox txt_MatKhau;
        private Button btn_login;
        private Button btn_Thoat;
        private Button btn_Quaylai;
    }
}