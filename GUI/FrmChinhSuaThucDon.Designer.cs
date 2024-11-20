namespace GUI
{
    partial class FrmChinhSuaThucDon
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
            lbChinhSua = new Label();
            lbTenThucDon = new Label();
            lbSoLuong = new Label();
            lbGhiChu = new Label();
            tbSoLuong = new TextBox();
            tbGhiChu = new TextBox();
            btLuu = new Button();
            btDong = new Button();
            lbThucDon = new Label();
            SuspendLayout();
            // 
            // lbChinhSua
            // 
            lbChinhSua.AutoSize = true;
            lbChinhSua.Location = new Point(286, 24);
            lbChinhSua.Name = "lbChinhSua";
            lbChinhSua.Size = new Size(112, 15);
            lbChinhSua.TabIndex = 0;
            lbChinhSua.Text = "Chỉnh sửa thực Đơn";
            // 
            // lbTenThucDon
            // 
            lbTenThucDon.AutoSize = true;
            lbTenThucDon.Location = new Point(37, 68);
            lbTenThucDon.Name = "lbTenThucDon";
            lbTenThucDon.Size = new Size(76, 15);
            lbTenThucDon.TabIndex = 1;
            lbTenThucDon.Text = "Tên thực đơn";
            // 
            // lbSoLuong
            // 
            lbSoLuong.AutoSize = true;
            lbSoLuong.Location = new Point(37, 114);
            lbSoLuong.Name = "lbSoLuong";
            lbSoLuong.Size = new Size(54, 15);
            lbSoLuong.TabIndex = 2;
            lbSoLuong.Text = "Số lượng";
            // 
            // lbGhiChu
            // 
            lbGhiChu.AutoSize = true;
            lbGhiChu.Location = new Point(37, 168);
            lbGhiChu.Name = "lbGhiChu";
            lbGhiChu.Size = new Size(48, 15);
            lbGhiChu.TabIndex = 3;
            lbGhiChu.Text = "Ghi chú";
            // 
            // tbSoLuong
            // 
            tbSoLuong.Location = new Point(157, 109);
            tbSoLuong.Margin = new Padding(3, 2, 3, 2);
            tbSoLuong.Name = "tbSoLuong";
            tbSoLuong.Size = new Size(110, 23);
            tbSoLuong.TabIndex = 4;
            // 
            // tbGhiChu
            // 
            tbGhiChu.Location = new Point(157, 163);
            tbGhiChu.Margin = new Padding(3, 2, 3, 2);
            tbGhiChu.Multiline = true;
            tbGhiChu.Name = "tbGhiChu";
            tbGhiChu.Size = new Size(350, 92);
            tbGhiChu.TabIndex = 5;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(64, 273);
            btLuu.Margin = new Padding(3, 2, 3, 2);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(115, 22);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu và đóng";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btDong
            // 
            btDong.Location = new Point(455, 273);
            btDong.Margin = new Padding(3, 2, 3, 2);
            btDong.Name = "btDong";
            btDong.Size = new Size(85, 22);
            btDong.TabIndex = 7;
            btDong.Text = "Đóng";
            btDong.UseVisualStyleBackColor = true;
            // 
            // lbThucDon
            // 
            lbThucDon.AutoSize = true;
            lbThucDon.Location = new Point(157, 68);
            lbThucDon.Name = "lbThucDon";
            lbThucDon.Size = new Size(0, 15);
            lbThucDon.TabIndex = 8;
            // 
            // FrmChinhSuaThucDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lbThucDon);
            Controls.Add(btDong);
            Controls.Add(btLuu);
            Controls.Add(tbGhiChu);
            Controls.Add(tbSoLuong);
            Controls.Add(lbGhiChu);
            Controls.Add(lbSoLuong);
            Controls.Add(lbTenThucDon);
            Controls.Add(lbChinhSua);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmChinhSuaThucDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChinhSuaThucDon";
            Load += FrmChinhSuaThucDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbChinhSua;
        private Label lbTenThucDon;
        private Label lbSoLuong;
        private Label lbGhiChu;
        private TextBox tbSoLuong;
        private TextBox tbGhiChu;
        private Button btLuu;
        private Button btDong;
        private Label lbThucDon;
    }
}