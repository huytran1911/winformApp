namespace GUI
{
    partial class NhanVien
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
            groupBox1 = new GroupBox();
            tbMaQuyen = new TextBox();
            label8 = new Label();
            tbMatKhau = new TextBox();
            tbDangNhap = new TextBox();
            tbEmail = new TextBox();
            tbSDT = new TextBox();
            tbDiaChi = new TextBox();
            tbTenNhanVien = new TextBox();
            tbMaNhanVien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbTimKiem = new TextBox();
            dgvDanhSachNhanVien = new DataGridView();
            bt_clear = new Button();
            bt_update = new Button();
            bt_add = new Button();
            bt_out = new Button();
            bt_find = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMaQuyen);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbMatKhau);
            groupBox1.Controls.Add(tbDangNhap);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(tbDiaChi);
            groupBox1.Controls.Add(tbTenNhanVien);
            groupBox1.Controls.Add(tbMaNhanVien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 473);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhân viên";
            // 
            // tbMaQuyen
            // 
            tbMaQuyen.Location = new Point(135, 418);
            tbMaQuyen.Multiline = true;
            tbMaQuyen.Name = "tbMaQuyen";
            tbMaQuyen.Size = new Size(233, 33);
            tbMaQuyen.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 426);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 14;
            label8.Text = "Mã Quyền";
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(135, 371);
            tbMatKhau.Multiline = true;
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(233, 33);
            tbMatKhau.TabIndex = 13;
            // 
            // tbDangNhap
            // 
            tbDangNhap.Location = new Point(135, 314);
            tbDangNhap.Multiline = true;
            tbDangNhap.Name = "tbDangNhap";
            tbDangNhap.Size = new Size(233, 33);
            tbDangNhap.TabIndex = 12;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(135, 261);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(233, 33);
            tbEmail.TabIndex = 11;
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(135, 213);
            tbSDT.Multiline = true;
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(233, 33);
            tbSDT.TabIndex = 10;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(135, 163);
            tbDiaChi.Multiline = true;
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(233, 33);
            tbDiaChi.TabIndex = 9;
            // 
            // tbTenNhanVien
            // 
            tbTenNhanVien.Location = new Point(135, 115);
            tbTenNhanVien.Multiline = true;
            tbTenNhanVien.Name = "tbTenNhanVien";
            tbTenNhanVien.Size = new Size(233, 33);
            tbTenNhanVien.TabIndex = 8;
            // 
            // tbMaNhanVien
            // 
            tbMaNhanVien.Location = new Point(135, 61);
            tbMaNhanVien.Name = "tbMaNhanVien";
            tbMaNhanVien.Size = new Size(233, 33);
            tbMaNhanVien.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 371);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 6;
            label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 314);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 5;
            label6.Text = "Đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 213);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 4;
            label5.Text = "SĐT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 261);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 163);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 69);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(414, 24);
            tbTimKiem.Multiline = true;
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.PlaceholderText = "Nhập mã nhân viên";
            tbTimKiem.Size = new Size(550, 33);
            tbTimKiem.TabIndex = 16;
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(414, 76);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNhanVien.Size = new Size(803, 412);
            dgvDanhSachNhanVien.TabIndex = 18;
            dgvDanhSachNhanVien.CellClick += dgvDanhSachNhanVien_CellClick;
            // 
            // bt_clear
            // 
            bt_clear.BackColor = Color.Crimson;
            bt_clear.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_clear.ForeColor = Color.White;
            bt_clear.Location = new Point(689, 525);
            bt_clear.Margin = new Padding(4, 3, 4, 3);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(162, 44);
            bt_clear.TabIndex = 21;
            bt_clear.Text = "Xóa";
            bt_clear.UseVisualStyleBackColor = false;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_update
            // 
            bt_update.BackColor = Color.ForestGreen;
            bt_update.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_update.ForeColor = Color.White;
            bt_update.Location = new Point(423, 525);
            bt_update.Margin = new Padding(4, 3, 4, 3);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(162, 44);
            bt_update.TabIndex = 20;
            bt_update.Text = "Cập Nhật";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += bt_update_Click;
            // 
            // bt_add
            // 
            bt_add.BackColor = Color.DodgerBlue;
            bt_add.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_add.ForeColor = Color.White;
            bt_add.Location = new Point(155, 525);
            bt_add.Margin = new Padding(4, 3, 4, 3);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(162, 44);
            bt_add.TabIndex = 19;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // bt_out
            // 
            bt_out.BackColor = Color.Crimson;
            bt_out.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_out.ForeColor = Color.White;
            bt_out.Location = new Point(923, 525);
            bt_out.Margin = new Padding(4, 3, 4, 3);
            bt_out.Name = "bt_out";
            bt_out.Size = new Size(162, 44);
            bt_out.TabIndex = 22;
            bt_out.Text = "Thoát";
            bt_out.UseVisualStyleBackColor = false;
            bt_out.Click += bt_out_Click;
            // 
            // bt_find
            // 
            bt_find.BackColor = Color.ForestGreen;
            bt_find.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_find.ForeColor = Color.White;
            bt_find.Location = new Point(980, 24);
            bt_find.Margin = new Padding(4, 3, 4, 3);
            bt_find.Name = "bt_find";
            bt_find.Size = new Size(168, 33);
            bt_find.TabIndex = 23;
            bt_find.Text = "Tìm Kiếm";
            bt_find.UseVisualStyleBackColor = false;
            bt_find.Click += bt_find_Click;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 591);
            Controls.Add(bt_find);
            Controls.Add(bt_out);
            Controls.Add(bt_clear);
            Controls.Add(bt_update);
            Controls.Add(bt_add);
            Controls.Add(dgvDanhSachNhanVien);
            Controls.Add(tbTimKiem);
            Controls.Add(groupBox1);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            Load += NhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbMatKhau;
        private TextBox tbDangNhap;
        private TextBox tbEmail;
        private TextBox tbSDT;
        private TextBox tbDiaChi;
        private TextBox tbTenNhanVien;
        private TextBox tbMaNhanVien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbTimKiem;
        private DataGridView dgvDanhSachNhanVien;
        private TextBox tbMaQuyen;
        private Label label8;
        private Button bt_clear;
        private Button bt_update;
        private Button bt_add;
        private Button bt_out;
        private Button bt_find;
    }
}