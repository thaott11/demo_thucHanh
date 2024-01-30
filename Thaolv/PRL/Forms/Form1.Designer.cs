namespace PRL.Forms
{
    partial class Form1
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Ten = new TextBox();
            txt_DiaChi = new TextBox();
            txt_Sdt = new TextBox();
            txt_Email = new TextBox();
            txt_PhuHuynh = new TextBox();
            txt_TimKiem = new TextBox();
            btn_Show = new Button();
            btn_Them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            dtgView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 61);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Đia Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 94);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 129);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 161);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 4;
            label5.Text = "ID Phụ Huynh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 198);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Tìm Kiếm:";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(122, 21);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(245, 23);
            txt_Ten.TabIndex = 6;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(122, 58);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(245, 23);
            txt_DiaChi.TabIndex = 7;
            // 
            // txt_Sdt
            // 
            txt_Sdt.Location = new Point(122, 94);
            txt_Sdt.Name = "txt_Sdt";
            txt_Sdt.Size = new Size(245, 23);
            txt_Sdt.TabIndex = 8;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(122, 126);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(245, 23);
            txt_Email.TabIndex = 9;
            // 
            // txt_PhuHuynh
            // 
            txt_PhuHuynh.Location = new Point(122, 161);
            txt_PhuHuynh.Name = "txt_PhuHuynh";
            txt_PhuHuynh.Size = new Size(245, 23);
            txt_PhuHuynh.TabIndex = 10;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(122, 198);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(245, 23);
            txt_TimKiem.TabIndex = 11;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(494, 12);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(75, 39);
            btn_Show.TabIndex = 12;
            btn_Show.Text = "Show";
            btn_Show.UseVisualStyleBackColor = true;
            btn_Show.Click += btn_Show_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(494, 70);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 39);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(494, 126);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(75, 37);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(494, 176);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(75, 37);
            btn_xoa.TabIndex = 15;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(31, 239);
            dtgView.Name = "dtgView";
            dtgView.RowTemplate.Height = 25;
            dtgView.Size = new Size(742, 232);
            dtgView.TabIndex = 16;
            dtgView.CellContentClick += dtgView_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgView);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_Them);
            Controls.Add(btn_Show);
            Controls.Add(txt_TimKiem);
            Controls.Add(txt_PhuHuynh);
            Controls.Add(txt_Email);
            Controls.Add(txt_Sdt);
            Controls.Add(txt_DiaChi);
            Controls.Add(txt_Ten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Ten;
        private TextBox txt_DiaChi;
        private TextBox txt_Sdt;
        private TextBox txt_Email;
        private TextBox txt_PhuHuynh;
        private TextBox txt_TimKiem;
        private Button btn_Show;
        private Button btn_Them;
        private Button btn_sua;
        private Button btn_xoa;
        private DataGridView dtgView;
    }
}