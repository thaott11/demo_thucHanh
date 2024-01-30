namespace PRL.Forms
{
    partial class Form_Dang_Nhap_Admincs
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
            btn_Quaylai = new Button();
            button4 = new Button();
            txt_Tentk = new TextBox();
            btn_Thoat = new Button();
            btn_Login = new Button();
            txt_MatKhau = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 39);
            label1.Name = "label1";
            label1.Size = new Size(244, 37);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 154);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 208);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // btn_Quaylai
            // 
            btn_Quaylai.Location = new Point(574, 286);
            btn_Quaylai.Name = "btn_Quaylai";
            btn_Quaylai.Size = new Size(168, 41);
            btn_Quaylai.TabIndex = 11;
            btn_Quaylai.Text = "Quay Lại";
            btn_Quaylai.UseVisualStyleBackColor = true;
            btn_Quaylai.Click += btn_Quaylai_Click;
            // 
            // button4
            // 
            button4.Location = new Point(305, 345);
            button4.Name = "button4";
            button4.Size = new Size(168, 42);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // txt_Tentk
            // 
            txt_Tentk.Location = new Point(276, 151);
            txt_Tentk.Name = "txt_Tentk";
            txt_Tentk.Size = new Size(269, 23);
            txt_Tentk.TabIndex = 13;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(62, 286);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(168, 41);
            btn_Thoat.TabIndex = 15;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click_1;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(305, 286);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(168, 41);
            btn_Login.TabIndex = 16;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(277, 205);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(268, 23);
            txt_MatKhau.TabIndex = 17;
            txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // Form_Dang_Nhap_Admincs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_MatKhau);
            Controls.Add(btn_Login);
            Controls.Add(btn_Thoat);
            Controls.Add(txt_Tentk);
            Controls.Add(button4);
            Controls.Add(btn_Quaylai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Dang_Nhap_Admincs";
            Text = "Form_Dang_Nhap_Admincs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button btn_Quaylai;
        private Button button4;
        private TextBox txt_Tentk;
        private Button btn_Thoat;
        private Button btn_Login;
        private TextBox txt_MatKhau;
    }
}