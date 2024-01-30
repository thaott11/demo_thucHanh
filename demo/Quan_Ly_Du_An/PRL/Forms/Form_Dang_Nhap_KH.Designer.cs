namespace PRL.Forms
{
    partial class Form_Dang_Nhap_KH
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
            txt_TênTK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btn_Thoat = new Button();
            btn_Login = new Button();
            btn_QuayLai = new Button();
            button1 = new Button();
            txt_MatKhau = new TextBox();
            SuspendLayout();
            // 
            // txt_TênTK
            // 
            txt_TênTK.Location = new Point(218, 92);
            txt_TênTK.Name = "txt_TênTK";
            txt_TênTK.Size = new Size(339, 23);
            txt_TênTK.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 24);
            label1.Name = "label1";
            label1.Size = new Size(312, 37);
            label1.TabIndex = 3;
            label1.Text = "Đăng Nhâp Khách Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 155);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 95);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Tên Tài Khoản";
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(73, 242);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(173, 54);
            btn_Thoat.TabIndex = 7;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(303, 242);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(173, 54);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_QuayLai
            // 
            btn_QuayLai.Location = new Point(534, 242);
            btn_QuayLai.Name = "btn_QuayLai";
            btn_QuayLai.Size = new Size(173, 54);
            btn_QuayLai.TabIndex = 9;
            btn_QuayLai.Text = "Quay Lại";
            btn_QuayLai.UseVisualStyleBackColor = true;
            btn_QuayLai.Click += btn_QuayLai_Click;
            // 
            // button1
            // 
            button1.Location = new Point(368, 13);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(218, 152);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(339, 23);
            txt_MatKhau.TabIndex = 11;
            txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // Form_Dang_Nhap_KH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_MatKhau);
            Controls.Add(button1);
            Controls.Add(btn_QuayLai);
            Controls.Add(btn_Login);
            Controls.Add(btn_Thoat);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_TênTK);
            Name = "Form_Dang_Nhap_KH";
            Text = "Form_Dang_Nhap_KH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_TênTK;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btn_Thoat;
        private Button btn_Login;
        private Button btn_QuayLai;
        private Button button1;
        private TextBox txt_MatKhau;
    }
}