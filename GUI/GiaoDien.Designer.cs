﻿namespace GUI
{
    partial class GiaoDien
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelBan = new FlowLayoutPanel();
            grbHoadon = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dgvThucDon = new DataGridView();
            btThanhtoan = new Button();
            tbThanhTien = new TextBox();
            tbPhuThu = new TextBox();
            tbGiamGia = new TextBox();
            lbThanhtien = new Label();
            lbPhuthu = new Label();
            lbGiamgia = new Label();
            btXoa = new Button();
            btChinhsua = new Button();
            btChonmon = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            lbKhachhang = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            lbBan01 = new Label();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            panelKhuVuc = new FlowLayoutPanel();
            danhToolStripMenuItem = new ToolStripMenuItem();
            bànToolStripMenuItem = new ToolStripMenuItem();
            danhSáchNhânViênToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            textTenNhanVien = new TextBox();
            grbHoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBan
            // 
            panelBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBan.BackColor = Color.DimGray;
            panelBan.Location = new Point(203, 32);
            panelBan.Margin = new Padding(2, 3, 2, 3);
            panelBan.Name = "panelBan";
            panelBan.Size = new Size(619, 1167);
            panelBan.TabIndex = 8;
            // 
            // grbHoadon
            // 
            grbHoadon.Controls.Add(textTenNhanVien);
            grbHoadon.Controls.Add(textBox3);
            grbHoadon.Controls.Add(textBox2);
            grbHoadon.Controls.Add(dgvThucDon);
            grbHoadon.Controls.Add(btThanhtoan);
            grbHoadon.Controls.Add(tbThanhTien);
            grbHoadon.Controls.Add(tbPhuThu);
            grbHoadon.Controls.Add(tbGiamGia);
            grbHoadon.Controls.Add(lbThanhtien);
            grbHoadon.Controls.Add(lbPhuthu);
            grbHoadon.Controls.Add(lbGiamgia);
            grbHoadon.Controls.Add(btXoa);
            grbHoadon.Controls.Add(btChinhsua);
            grbHoadon.Controls.Add(btChonmon);
            grbHoadon.Controls.Add(label1);
            grbHoadon.Controls.Add(textBox1);
            grbHoadon.Controls.Add(lbKhachhang);
            grbHoadon.Controls.Add(dateTimePicker1);
            grbHoadon.Controls.Add(label2);
            grbHoadon.Controls.Add(lbBan01);
            grbHoadon.Dock = DockStyle.Right;
            grbHoadon.Font = new Font("Segoe UI", 9F);
            grbHoadon.Location = new Point(827, 30);
            grbHoadon.Margin = new Padding(2, 3, 2, 3);
            grbHoadon.Name = "grbHoadon";
            grbHoadon.Padding = new Padding(2, 3, 2, 3);
            grbHoadon.Size = new Size(557, 1025);
            grbHoadon.TabIndex = 9;
            grbHoadon.TabStop = false;
            grbHoadon.Text = "Chi tiết hóa đơn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(313, 900);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 27);
            textBox3.TabIndex = 22;
            textBox3.Text = "Phần trăm(%)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 836);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 27);
            textBox2.TabIndex = 21;
            textBox2.Text = "Phần trăm(%)";
            // 
            // dgvThucDon
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvThucDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvThucDon.DefaultCellStyle = dataGridViewCellStyle5;
            dgvThucDon.Location = new Point(6, 300);
            dgvThucDon.Name = "dgvThucDon";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvThucDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvThucDon.RowHeadersWidth = 51;
            dgvThucDon.Size = new Size(528, 495);
            dgvThucDon.TabIndex = 20;
            // 
            // btThanhtoan
            // 
            btThanhtoan.BackColor = Color.DodgerBlue;
            btThanhtoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThanhtoan.ForeColor = Color.White;
            btThanhtoan.Location = new Point(115, 1016);
            btThanhtoan.Margin = new Padding(2, 3, 2, 3);
            btThanhtoan.Name = "btThanhtoan";
            btThanhtoan.Size = new Size(238, 69);
            btThanhtoan.TabIndex = 19;
            btThanhtoan.Text = "Thanh toán";
            btThanhtoan.UseVisualStyleBackColor = false;
            // 
            // tbThanhTien
            // 
            tbThanhTien.Location = new Point(115, 959);
            tbThanhTien.Margin = new Padding(2, 3, 2, 3);
            tbThanhTien.Name = "tbThanhTien";
            tbThanhTien.ReadOnly = true;
            tbThanhTien.Size = new Size(293, 27);
            tbThanhTien.TabIndex = 16;
            // 
            // tbPhuThu
            // 
            tbPhuThu.Location = new Point(113, 900);
            tbPhuThu.Margin = new Padding(2, 3, 2, 3);
            tbPhuThu.Name = "tbPhuThu";
            tbPhuThu.Size = new Size(166, 27);
            tbPhuThu.TabIndex = 15;
            tbPhuThu.Text = "0";
            tbPhuThu.TextAlign = HorizontalAlignment.Right;
            tbPhuThu.TextChanged += tbPhuThu_TextChanged;
            tbPhuThu.KeyPress += nhapSo;
            // 
            // tbGiamGia
            // 
            tbGiamGia.Cursor = Cursors.IBeam;
            tbGiamGia.Location = new Point(113, 836);
            tbGiamGia.Margin = new Padding(2, 3, 2, 3);
            tbGiamGia.Name = "tbGiamGia";
            tbGiamGia.Size = new Size(166, 27);
            tbGiamGia.TabIndex = 14;
            tbGiamGia.Text = "0";
            tbGiamGia.TextAlign = HorizontalAlignment.Right;
            tbGiamGia.TextChanged += tbGiamGia_TextChanged;
            tbGiamGia.KeyPress += nhapSo;
            // 
            // lbThanhtien
            // 
            lbThanhtien.AutoSize = true;
            lbThanhtien.Location = new Point(26, 967);
            lbThanhtien.Margin = new Padding(2, 0, 2, 0);
            lbThanhtien.Name = "lbThanhtien";
            lbThanhtien.Size = new Size(81, 20);
            lbThanhtien.TabIndex = 13;
            lbThanhtien.Text = "Thành tiền:";
            // 
            // lbPhuthu
            // 
            lbPhuthu.AutoSize = true;
            lbPhuthu.Location = new Point(27, 904);
            lbPhuthu.Margin = new Padding(2, 0, 2, 0);
            lbPhuthu.Name = "lbPhuthu";
            lbPhuthu.Size = new Size(61, 20);
            lbPhuthu.TabIndex = 12;
            lbPhuthu.Text = "Phụ thu:";
            // 
            // lbGiamgia
            // 
            lbGiamgia.AutoSize = true;
            lbGiamgia.Location = new Point(22, 836);
            lbGiamgia.Margin = new Padding(2, 0, 2, 0);
            lbGiamgia.Name = "lbGiamgia";
            lbGiamgia.Size = new Size(72, 20);
            lbGiamgia.TabIndex = 11;
            lbGiamgia.Text = "Giảm giá:";
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.Red;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.ForeColor = Color.White;
            btXoa.Location = new Point(343, 196);
            btXoa.Margin = new Padding(2, 3, 2, 3);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(138, 57);
            btXoa.TabIndex = 9;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btChinhsua
            // 
            btChinhsua.BackColor = Color.Yellow;
            btChinhsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChinhsua.Location = new Point(176, 196);
            btChinhsua.Margin = new Padding(2, 3, 2, 3);
            btChinhsua.Name = "btChinhsua";
            btChinhsua.Size = new Size(138, 57);
            btChinhsua.TabIndex = 8;
            btChinhsua.Text = "Chỉnh sửa";
            btChinhsua.UseVisualStyleBackColor = false;
            btChinhsua.Click += btChinhsua_Click;
            // 
            // btChonmon
            // 
            btChonmon.BackColor = Color.Green;
            btChonmon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChonmon.ForeColor = Color.White;
            btChonmon.Location = new Point(21, 196);
            btChonmon.Margin = new Padding(2, 3, 2, 3);
            btChonmon.Name = "btChonmon";
            btChonmon.Size = new Size(133, 57);
            btChonmon.TabIndex = 7;
            btChonmon.Text = "Chọn món";
            btChonmon.UseVisualStyleBackColor = false;
            btChonmon.Click += btChonmon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 156);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 5;
            label1.Text = "Nhân viên:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(118, 103);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 27);
            textBox1.TabIndex = 4;
            // 
            // lbKhachhang
            // 
            lbKhachhang.AutoSize = true;
            lbKhachhang.Location = new Point(21, 103);
            lbKhachhang.Margin = new Padding(2, 0, 2, 0);
            lbKhachhang.Name = "lbKhachhang";
            lbKhachhang.Size = new Size(89, 20);
            lbKhachhang.TabIndex = 3;
            lbKhachhang.Text = "Khách hàng:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 7F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(118, 55);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(277, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày vào:";
            // 
            // lbBan01
            // 
            lbBan01.AutoSize = true;
            lbBan01.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbBan01.Location = new Point(5, 21);
            lbBan01.Margin = new Padding(2, 0, 2, 0);
            lbBan01.Name = "lbBan01";
            lbBan01.Size = new Size(0, 28);
            lbBan01.TabIndex = 0;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(224, 26);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // panelKhuVuc
            // 
            panelKhuVuc.BackColor = Color.DarkGray;
            panelKhuVuc.Dock = DockStyle.Left;
            panelKhuVuc.Location = new Point(0, 30);
            panelKhuVuc.Name = "panelKhuVuc";
            panelKhuVuc.Size = new Size(206, 1025);
            panelKhuVuc.TabIndex = 11;
            // 
            // danhToolStripMenuItem
            // 
            danhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bànToolStripMenuItem, danhSáchNhânViênToolStripMenuItem });
            danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            danhToolStripMenuItem.Size = new Size(90, 24);
            danhToolStripMenuItem.Text = "Danh mục";
            // 
            // bànToolStripMenuItem
            // 
            bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            bànToolStripMenuItem.Size = new Size(227, 26);
            bànToolStripMenuItem.Text = "Bàn";
            bànToolStripMenuItem.Click += bànToolStripMenuItem_Click;
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            danhSáchNhânViênToolStripMenuItem.Size = new Size(227, 26);
            danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            danhSáchNhânViênToolStripMenuItem.Click += danhSáchNhânViênToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 3, 0, 3);
            menuStrip1.Size = new Size(1384, 30);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(160, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(160, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // textTenNhanVien
            // 
            textTenNhanVien.Cursor = Cursors.IBeam;
            textTenNhanVien.Location = new Point(118, 153);
            textTenNhanVien.Margin = new Padding(2, 3, 2, 3);
            textTenNhanVien.Name = "textTenNhanVien";
            textTenNhanVien.Size = new Size(277, 27);
            textTenNhanVien.TabIndex = 23;
            // 
            // GiaoDien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1384, 1055);
            Controls.Add(panelKhuVuc);
            Controls.Add(grbHoadon);
            Controls.Add(panelBan);
            Controls.Add(menuStrip1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "GiaoDien";
            Text = "Quản lý cà phê";
            WindowState = FormWindowState.Maximized;
            Load += GiaoDien_Load;
            grbHoadon.ResumeLayout(false);
            grbHoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel panelBan;
        private GroupBox grbHoadon;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox1;
        private Label lbKhachhang;
        private Button btChonmon;
        private Button btXoa;
        private Button btChinhsua;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private Label lbThanhtien;
        private Label lbPhuthu;
        private Label lbGiamgia;
        private TextBox tbGiamGia;
        private Button btThanhtoan;
        private TextBox tbThanhTien;
        private TextBox tbPhuThu;
        private FlowLayoutPanel panelKhuVuc;
        private Label lbBan01;
        private ListView listThucDon;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripMenuItem danhToolStripMenuItem;
        private ToolStripMenuItem bànToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private DataGridView dgvThucDon;
        private ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textTenNhanVien;
    }
}
