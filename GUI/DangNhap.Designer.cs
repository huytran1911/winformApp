namespace GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(478, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 62);
            label1.TabIndex = 1;
            label1.Text = "T1 COFFEE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(507, 100);
            label2.Name = "label2";
            label2.Size = new Size(200, 46);
            label2.TabIndex = 2;
            label2.Text = "Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 195);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên đăng nhập:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 245);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(565, 188);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(206, 27);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(565, 245);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(206, 27);
            txtMatKhau.TabIndex = 6;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(659, 363);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(112, 47);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(435, 363);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 47);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 28);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(301, 381);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(pictureBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private PictureBox pictureBox2;
    }
}