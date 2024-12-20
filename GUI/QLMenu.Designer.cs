﻿namespace GUI
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
            btThoat = new Button();
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
            label1.Location = new Point(256, 25);
            label1.Name = "label1";
            label1.Size = new Size(206, 40);
            label1.TabIndex = 1;
            label1.Text = "Quản lý MENU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 99);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã thực đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 140);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Tên thực đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 181);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 4;
            label4.Text = "Giá";
            // 
            // tbMaThucDon
            // 
            tbMaThucDon.Location = new Point(162, 99);
            tbMaThucDon.Name = "tbMaThucDon";
            tbMaThucDon.Size = new Size(492, 23);
            tbMaThucDon.TabIndex = 4;
            // 
            // tbTenThucDon
            // 
            tbTenThucDon.Location = new Point(162, 137);
            tbTenThucDon.Name = "tbTenThucDon";
            tbTenThucDon.Size = new Size(492, 23);
            tbTenThucDon.TabIndex = 6;
            // 
            // tbGia
            // 
            tbGia.Location = new Point(162, 173);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(492, 23);
            tbGia.TabIndex = 7;
            // 
            // btThem
            // 
            btThem.Location = new Point(36, 228);
            btThem.Name = "btThem";
            btThem.Size = new Size(75, 23);
            btThem.TabIndex = 8;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(162, 228);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(75, 23);
            btXoa.TabIndex = 9;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(317, 228);
            btSua.Name = "btSua";
            btSua.Size = new Size(75, 23);
            btSua.TabIndex = 10;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(461, 228);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 11;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(36, 273);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.Size = new Size(618, 262);
            dgvMenu.TabIndex = 12;
            dgvMenu.CellClick += dgvMenu_CellClick;
            // 
            // QLMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 547);
            Controls.Add(dgvMenu);
            Controls.Add(btThoat);
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
        private Button btThoat;
        private DataGridView dgvMenu;
    }
}