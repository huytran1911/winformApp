namespace GUI
{
    partial class QLMenu
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbMaThucDon = new TextBox();
            tbTenThucDon = new TextBox();
            tbGia = new TextBox();
            btThem = new Button();
            btXoa = new Button();
            btSua = new Button();
            Thoát = new Button();
            dgvMenu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 33);
            label1.Name = "label1";
            label1.Size = new Size(263, 50);
            label1.TabIndex = 1;
            label1.Text = "Quản lý MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 132);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã thực đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 187);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên thực đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 241);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 4;
            label4.Text = "Giá";
            // 
            // tbMaThucDon
            // 
            tbMaThucDon.Location = new Point(185, 132);
            tbMaThucDon.Margin = new Padding(3, 4, 3, 4);
            tbMaThucDon.Name = "tbMaThucDon";
            tbMaThucDon.Size = new Size(562, 27);
            tbMaThucDon.TabIndex = 4;
            // 
            // tbTenThucDon
            // 
            tbTenThucDon.Location = new Point(185, 183);
            tbTenThucDon.Margin = new Padding(3, 4, 3, 4);
            tbTenThucDon.Name = "tbTenThucDon";
            tbTenThucDon.Size = new Size(562, 27);
            tbTenThucDon.TabIndex = 6;
            // 
            // tbGia
            // 
            tbGia.Location = new Point(185, 231);
            tbGia.Margin = new Padding(3, 4, 3, 4);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(562, 27);
            tbGia.TabIndex = 7;
            // 
            // btThem
            // 
            btThem.Location = new Point(41, 304);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(86, 31);
            btThem.TabIndex = 8;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(185, 304);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(86, 31);
            btXoa.TabIndex = 9;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(362, 304);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(86, 31);
            btSua.TabIndex = 10;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // Thoát
            // 
            Thoát.Location = new Point(527, 304);
            Thoát.Margin = new Padding(3, 4, 3, 4);
            Thoát.Name = "Thoát";
            Thoát.Size = new Size(86, 31);
            Thoát.TabIndex = 11;
            Thoát.Text = "Thoát";
            Thoát.UseVisualStyleBackColor = true;
            // 
            // dgvMenu
            // 
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(41, 364);
            dgvMenu.Margin = new Padding(3, 4, 3, 4);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new Size(706, 349);
            dgvMenu.TabIndex = 12;
            dgvMenu.CellClick += dgvMenu_CellClick;
            // 
            // QLMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 729);
            Controls.Add(dgvMenu);
            Controls.Add(Thoát);
            Controls.Add(btSua);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(tbGia);
            Controls.Add(tbTenThucDon);
            Controls.Add(tbMaThucDon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QLMenu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QLMenu";
            Load += QLMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMaThucDon;
        private TextBox tbTenThucDon;
        private TextBox tbGia;
        private Button btThem;
        private Button btXoa;
        private Button btSua;
        private Button Thoát;
        private DataGridView dgvMenu;
    }
}