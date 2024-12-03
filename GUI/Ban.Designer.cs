namespace GUI
{
    partial class Ban
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
            gb_Ban = new GroupBox();
            tbMaKhuVuc = new TextBox();
            tbTenBan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            gb_listBan = new GroupBox();
            dgv_listBan = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            bt_add = new Button();
            bt_update = new Button();
            bt_clear = new Button();
            bt_find = new Button();
            bt_out = new Button();
            tb_find = new TextBox();
            gb_Ban.SuspendLayout();
            gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_listBan).BeginInit();
            SuspendLayout();
            // 
            // gb_Ban
            // 
            gb_Ban.Controls.Add(tbMaKhuVuc);
            gb_Ban.Controls.Add(tbTenBan);
            gb_Ban.Controls.Add(label3);
            gb_Ban.Controls.Add(label2);
            gb_Ban.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            gb_Ban.Location = new Point(15, 152);
            gb_Ban.Margin = new Padding(2, 3, 2, 3);
            gb_Ban.Name = "gb_Ban";
            gb_Ban.Padding = new Padding(2, 3, 2, 3);
            gb_Ban.Size = new Size(694, 349);
            gb_Ban.TabIndex = 0;
            gb_Ban.TabStop = false;
            gb_Ban.Text = "Số Bàn";
            // 
            // tbMaKhuVuc
            // 
            tbMaKhuVuc.Location = new Point(283, 173);
            tbMaKhuVuc.Margin = new Padding(2, 3, 2, 3);
            tbMaKhuVuc.Name = "tbMaKhuVuc";
            tbMaKhuVuc.Size = new Size(374, 28);
            tbMaKhuVuc.TabIndex = 3;
            // 
            // tbTenBan
            // 
            tbTenBan.Location = new Point(283, 100);
            tbTenBan.Margin = new Padding(2, 3, 2, 3);
            tbTenBan.Name = "tbTenBan";
            tbTenBan.Size = new Size(374, 28);
            tbTenBan.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label3.Location = new Point(44, 181);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 1;
            label3.Text = "Mã Khu Vực: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label2.Location = new Point(44, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên Bàn: ";
            // 
            // gb_listBan
            // 
            gb_listBan.Controls.Add(dgv_listBan);
            gb_listBan.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            gb_listBan.Location = new Point(808, 83);
            gb_listBan.Margin = new Padding(2, 3, 2, 3);
            gb_listBan.Name = "gb_listBan";
            gb_listBan.Padding = new Padding(2, 3, 2, 3);
            gb_listBan.Size = new Size(895, 616);
            gb_listBan.TabIndex = 0;
            gb_listBan.TabStop = false;
            gb_listBan.Text = "Danh Sách Bàn";
            // 
            // dgv_listBan
            // 
            dgv_listBan.BackgroundColor = SystemColors.ButtonFace;
            dgv_listBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listBan.Location = new Point(6, 49);
            dgv_listBan.Margin = new Padding(2, 3, 2, 3);
            dgv_listBan.Name = "dgv_listBan";
            dgv_listBan.ReadOnly = true;
            dgv_listBan.RowHeadersWidth = 51;
            dgv_listBan.RowTemplate.Height = 24;
            dgv_listBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_listBan.Size = new Size(885, 561);
            dgv_listBan.TabIndex = 0;
            dgv_listBan.CellClick += dgv_listBan_CellClick;
            // 
            // bt_add
            // 
            bt_add.BackColor = Color.DodgerBlue;
            bt_add.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_add.ForeColor = Color.White;
            bt_add.Location = new Point(15, 43);
            bt_add.Margin = new Padding(5, 4, 5, 4);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(185, 59);
            bt_add.TabIndex = 4;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // bt_update
            // 
            bt_update.BackColor = Color.ForestGreen;
            bt_update.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_update.ForeColor = Color.White;
            bt_update.Location = new Point(267, 43);
            bt_update.Margin = new Padding(5, 4, 5, 4);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(185, 59);
            bt_update.TabIndex = 5;
            bt_update.Text = "Cập Nhật";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += bt_update_Click;
            // 
            // bt_clear
            // 
            bt_clear.BackColor = Color.Crimson;
            bt_clear.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_clear.ForeColor = Color.White;
            bt_clear.Location = new Point(521, 43);
            bt_clear.Margin = new Padding(5, 4, 5, 4);
            bt_clear.Name = "bt_clear";
            bt_clear.Size = new Size(185, 59);
            bt_clear.TabIndex = 6;
            bt_clear.Text = "Xóa";
            bt_clear.UseVisualStyleBackColor = false;
            bt_clear.Click += bt_clear_Click;
            // 
            // bt_find
            // 
            bt_find.BackColor = Color.ForestGreen;
            bt_find.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_find.ForeColor = Color.White;
            bt_find.Location = new Point(1429, 20);
            bt_find.Margin = new Padding(5, 4, 5, 4);
            bt_find.Name = "bt_find";
            bt_find.Size = new Size(270, 59);
            bt_find.TabIndex = 9;
            bt_find.Text = "Tìm Kiếm";
            bt_find.UseVisualStyleBackColor = false;
            // 
            // bt_out
            // 
            bt_out.BackColor = Color.Crimson;
            bt_out.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            bt_out.ForeColor = Color.White;
            bt_out.Location = new Point(16, 640);
            bt_out.Margin = new Padding(5, 4, 5, 4);
            bt_out.Name = "bt_out";
            bt_out.Size = new Size(185, 59);
            bt_out.TabIndex = 7;
            bt_out.Text = "Thoát";
            bt_out.UseVisualStyleBackColor = false;
            bt_out.Click += bt_out_Click;
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(814, 29);
            tb_find.Margin = new Padding(2, 3, 2, 3);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(606, 27);
            tb_find.TabIndex = 8;
            tb_find.Text = "Nhập từ khóa cần tìm";
            // 
            // Ban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 729);
            Controls.Add(tb_find);
            Controls.Add(bt_out);
            Controls.Add(bt_find);
            Controls.Add(bt_clear);
            Controls.Add(bt_update);
            Controls.Add(bt_add);
            Controls.Add(gb_listBan);
            Controls.Add(gb_Ban);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ban";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ BÀN";
            Load += Ban_Load;
            gb_Ban.ResumeLayout(false);
            gb_Ban.PerformLayout();
            gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_listBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.TextBox tbMaKhuVuc;
        private System.Windows.Forms.TextBox tbTenBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_listBan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Button bt_out;
        private System.Windows.Forms.TextBox tb_find;
    }
}