namespace GUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            comboBox1 = new ComboBox();
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
            grbHoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBan
            // 
            panelBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBan.BackColor = Color.DimGray;
            panelBan.Location = new Point(178, 24);
            panelBan.Margin = new Padding(2);
            panelBan.Name = "panelBan";
            panelBan.Size = new Size(542, 875);
            panelBan.TabIndex = 8;
            // 
            // grbHoadon
            // 
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
            grbHoadon.Controls.Add(comboBox1);
            grbHoadon.Controls.Add(label1);
            grbHoadon.Controls.Add(textBox1);
            grbHoadon.Controls.Add(lbKhachhang);
            grbHoadon.Controls.Add(dateTimePicker1);
            grbHoadon.Controls.Add(label2);
            grbHoadon.Controls.Add(lbBan01);
            grbHoadon.Dock = DockStyle.Right;
            grbHoadon.Font = new Font("Segoe UI", 9F);
            grbHoadon.Location = new Point(724, 24);
            grbHoadon.Margin = new Padding(2);
            grbHoadon.Name = "grbHoadon";
            grbHoadon.Padding = new Padding(2);
            grbHoadon.Size = new Size(487, 875);
            grbHoadon.TabIndex = 9;
            grbHoadon.TabStop = false;
            grbHoadon.Text = "Chi tiết hóa đơn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(274, 675);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(84, 23);
            textBox3.TabIndex = 22;
            textBox3.Text = "Phần trăm(%)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 627);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(84, 23);
            textBox2.TabIndex = 21;
            textBox2.Text = "Phần trăm(%)";
            // 
            // dgvThucDon
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvThucDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvThucDon.DefaultCellStyle = dataGridViewCellStyle2;
            dgvThucDon.Location = new Point(5, 225);
            dgvThucDon.Margin = new Padding(3, 2, 3, 2);
            dgvThucDon.Name = "dgvThucDon";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvThucDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvThucDon.RowHeadersWidth = 51;
            dgvThucDon.Size = new Size(462, 371);
            dgvThucDon.TabIndex = 20;
            // 
            // btThanhtoan
            // 
            btThanhtoan.BackColor = Color.DodgerBlue;
            btThanhtoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThanhtoan.ForeColor = Color.White;
            btThanhtoan.Location = new Point(101, 762);
            btThanhtoan.Margin = new Padding(2);
            btThanhtoan.Name = "btThanhtoan";
            btThanhtoan.Size = new Size(208, 52);
            btThanhtoan.TabIndex = 19;
            btThanhtoan.Text = "Thanh toán";
            btThanhtoan.UseVisualStyleBackColor = false;
            // 
            // tbThanhTien
            // 
            tbThanhTien.Location = new Point(101, 719);
            tbThanhTien.Margin = new Padding(2);
            tbThanhTien.Name = "tbThanhTien";
            tbThanhTien.ReadOnly = true;
            tbThanhTien.Size = new Size(257, 23);
            tbThanhTien.TabIndex = 16;
            // 
            // tbPhuThu
            // 
            tbPhuThu.Location = new Point(99, 675);
            tbPhuThu.Margin = new Padding(2);
            tbPhuThu.Name = "tbPhuThu";
            tbPhuThu.Size = new Size(146, 23);
            tbPhuThu.TabIndex = 15;
            tbPhuThu.Text = "0";
            tbPhuThu.TextAlign = HorizontalAlignment.Right;
            tbPhuThu.KeyPress += nhapSo;
            // 
            // tbGiamGia
            // 
            tbGiamGia.Cursor = Cursors.IBeam;
            tbGiamGia.Location = new Point(99, 627);
            tbGiamGia.Margin = new Padding(2);
            tbGiamGia.Name = "tbGiamGia";
            tbGiamGia.Size = new Size(146, 23);
            tbGiamGia.TabIndex = 14;
            tbGiamGia.Text = "0";
            tbGiamGia.TextAlign = HorizontalAlignment.Right;
            tbGiamGia.TextChanged += tbGiamGia_TextChanged;
            tbGiamGia.KeyPress += nhapSo;
            // 
            // lbThanhtien
            // 
            lbThanhtien.AutoSize = true;
            lbThanhtien.Location = new Point(23, 725);
            lbThanhtien.Margin = new Padding(2, 0, 2, 0);
            lbThanhtien.Name = "lbThanhtien";
            lbThanhtien.Size = new Size(66, 15);
            lbThanhtien.TabIndex = 13;
            lbThanhtien.Text = "Thành tiền:";
            // 
            // lbPhuthu
            // 
            lbPhuthu.AutoSize = true;
            lbPhuthu.Location = new Point(24, 678);
            lbPhuthu.Margin = new Padding(2, 0, 2, 0);
            lbPhuthu.Name = "lbPhuthu";
            lbPhuthu.Size = new Size(52, 15);
            lbPhuthu.TabIndex = 12;
            lbPhuthu.Text = "Phụ thu:";
            // 
            // lbGiamgia
            // 
            lbGiamgia.AutoSize = true;
            lbGiamgia.Location = new Point(19, 627);
            lbGiamgia.Margin = new Padding(2, 0, 2, 0);
            lbGiamgia.Name = "lbGiamgia";
            lbGiamgia.Size = new Size(57, 15);
            lbGiamgia.TabIndex = 11;
            lbGiamgia.Text = "Giảm giá:";
            // 
            // btXoa
            // 
            btXoa.BackColor = Color.Red;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.ForeColor = Color.White;
            btXoa.Location = new Point(300, 147);
            btXoa.Margin = new Padding(2);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(121, 43);
            btXoa.TabIndex = 9;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btChinhsua
            // 
            btChinhsua.BackColor = Color.Yellow;
            btChinhsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btChinhsua.Location = new Point(154, 147);
            btChinhsua.Margin = new Padding(2);
            btChinhsua.Name = "btChinhsua";
            btChinhsua.Size = new Size(121, 43);
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
            btChonmon.Location = new Point(18, 147);
            btChonmon.Margin = new Padding(2);
            btChonmon.Name = "btChonmon";
            btChonmon.Size = new Size(116, 43);
            btChonmon.TabIndex = 7;
            btChonmon.Text = "Chọn món";
            btChonmon.UseVisualStyleBackColor = false;
            btChonmon.Click += btChonmon_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 114);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 23);
            comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 117);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Nhân viên:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(103, 77);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 4;
            // 
            // lbKhachhang
            // 
            lbKhachhang.AutoSize = true;
            lbKhachhang.Location = new Point(18, 77);
            lbKhachhang.Margin = new Padding(2, 0, 2, 0);
            lbKhachhang.Name = "lbKhachhang";
            lbKhachhang.Size = new Size(73, 15);
            lbKhachhang.TabIndex = 3;
            lbKhachhang.Text = "Khách hàng:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 7F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(103, 41);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày vào:";
            // 
            // lbBan01
            // 
            lbBan01.AutoSize = true;
            lbBan01.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbBan01.Location = new Point(4, 16);
            lbBan01.Margin = new Padding(2, 0, 2, 0);
            lbBan01.Name = "lbBan01";
            lbBan01.Size = new Size(0, 21);
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
            panelKhuVuc.Location = new Point(0, 24);
            panelKhuVuc.Margin = new Padding(3, 2, 3, 2);
            panelKhuVuc.Name = "panelKhuVuc";
            panelKhuVuc.Size = new Size(180, 875);
            panelKhuVuc.TabIndex = 11;
            // 
            // danhToolStripMenuItem
            // 
            danhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bànToolStripMenuItem, danhSáchNhânViênToolStripMenuItem });
            danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            danhToolStripMenuItem.Size = new Size(74, 20);
            danhToolStripMenuItem.Text = "Danh mục";
            // 
            // bànToolStripMenuItem
            // 
            bànToolStripMenuItem.Name = "bànToolStripMenuItem";
            bànToolStripMenuItem.Size = new Size(184, 22);
            bànToolStripMenuItem.Text = "Bàn";
            bànToolStripMenuItem.Click += bànToolStripMenuItem_Click;
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            danhSáchNhânViênToolStripMenuItem.Size = new Size(184, 22);
            danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            danhSáchNhânViênToolStripMenuItem.Click += danhSáchNhânViênToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(1211, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(128, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(128, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // GiaoDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1211, 899);
            Controls.Add(panelKhuVuc);
            Controls.Add(grbHoadon);
            Controls.Add(panelBan);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
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
        private ComboBox comboBox1;
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
    }
}
