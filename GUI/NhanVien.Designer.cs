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
            Thoát = new Button();
            btSua = new Button();
            btXoa = new Button();
            btThem = new Button();
            tbTimKiem = new TextBox();
            btTimKiem = new Button();
            dgvDanhSachNhanVien = new DataGridView();
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
            tbMaQuyen.Location = new Point(168, 418);
            tbMaQuyen.Multiline = true;
            tbMaQuyen.Name = "tbMaQuyen";
            tbMaQuyen.Size = new Size(200, 33);
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
            tbMatKhau.Location = new Point(168, 371);
            tbMatKhau.Multiline = true;
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(200, 33);
            tbMatKhau.TabIndex = 13;
            // 
            // tbDangNhap
            // 
            tbDangNhap.Location = new Point(168, 314);
            tbDangNhap.Multiline = true;
            tbDangNhap.Name = "tbDangNhap";
            tbDangNhap.Size = new Size(200, 33);
            tbDangNhap.TabIndex = 12;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(168, 261);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 33);
            tbEmail.TabIndex = 11;
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(168, 213);
            tbSDT.Multiline = true;
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(200, 33);
            tbSDT.TabIndex = 10;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(168, 163);
            tbDiaChi.Multiline = true;
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(200, 33);
            tbDiaChi.TabIndex = 9;
            // 
            // tbTenNhanVien
            // 
            tbTenNhanVien.Location = new Point(168, 115);
            tbTenNhanVien.Multiline = true;
            tbTenNhanVien.Name = "tbTenNhanVien";
            tbTenNhanVien.Size = new Size(200, 33);
            tbTenNhanVien.TabIndex = 8;
            // 
            // tbMaNhanVien
            // 
            tbMaNhanVien.Location = new Point(168, 61);
            tbMaNhanVien.Name = "tbMaNhanVien";
            tbMaNhanVien.Size = new Size(200, 33);
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
            // Thoát
            // 
            Thoát.Location = new Point(917, 525);
            Thoát.Name = "Thoát";
            Thoát.Size = new Size(75, 23);
            Thoát.TabIndex = 15;
            Thoát.Text = "Thoát";
            Thoát.UseVisualStyleBackColor = true;
            Thoát.Click += Thoát_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(695, 525);
            btSua.Name = "btSua";
            btSua.Size = new Size(75, 23);
            btSua.TabIndex = 14;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(414, 525);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(75, 23);
            btXoa.TabIndex = 13;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btThem
            // 
            btThem.Location = new Point(207, 525);
            btThem.Name = "btThem";
            btThem.Size = new Size(75, 23);
            btThem.TabIndex = 12;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(414, 24);
            tbTimKiem.Multiline = true;
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(550, 33);
            tbTimKiem.TabIndex = 16;
            // 
            // btTimKiem
            // 
            btTimKiem.Location = new Point(1001, 24);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(94, 33);
            btTimKiem.TabIndex = 17;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = true;
            btTimKiem.Click += btTimKiem_Click;
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new Point(414, 85);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachNhanVien.Size = new Size(803, 412);
            dgvDanhSachNhanVien.TabIndex = 18;
            dgvDanhSachNhanVien.RowPrePaint += dgvDanhSachNhanVien_RowPrePaint;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 591);
            Controls.Add(dgvDanhSachNhanVien);
            Controls.Add(btTimKiem);
            Controls.Add(tbTimKiem);
            Controls.Add(Thoát);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(groupBox1);
            Name = "NhanVien";
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
        private Button Thoát;
        private Button btSua;
        private Button btXoa;
        private Button btThem;
        private TextBox tbTimKiem;
        private Button btTimKiem;
        private DataGridView dgvDanhSachNhanVien;
        private TextBox tbMaQuyen;
        private Label label8;
    }
}