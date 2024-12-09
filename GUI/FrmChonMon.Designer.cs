namespace GUI
{
    partial class FrmChonMon
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
            dgvChonMon = new DataGridView();
            btThoat = new Button();
            btChon = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChonMon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvChonMon);
            groupBox1.Controls.Add(btThoat);
            groupBox1.Controls.Add(btChon);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(700, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn thực đơn";
            // 
            // dgvChonMon
            // 
            dgvChonMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChonMon.Location = new Point(10, 33);
            dgvChonMon.Margin = new Padding(3, 2, 3, 2);
            dgvChonMon.Name = "dgvChonMon";
            dgvChonMon.RowHeadersWidth = 51;
            dgvChonMon.Size = new Size(670, 268);
            dgvChonMon.TabIndex = 4;
            dgvChonMon.CellClick += dgvChonMon_CellClick;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.Crimson;
            btThoat.ForeColor = Color.White;
            btThoat.Location = new Point(496, 306);
            btThoat.Margin = new Padding(3, 2, 3, 2);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(125, 22);
            btThoat.TabIndex = 3;
            btThoat.Text = "Hủy chọn";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // btChon
            // 
            btChon.BackColor = Color.DeepSkyBlue;
            btChon.DialogResult = DialogResult.OK;
            btChon.ForeColor = Color.White;
            btChon.Location = new Point(38, 306);
            btChon.Margin = new Padding(3, 2, 3, 2);
            btChon.Name = "btChon";
            btChon.Size = new Size(134, 22);
            btChon.TabIndex = 2;
            btChon.Text = "Chọn và đóng";
            btChon.UseVisualStyleBackColor = false;
            btChon.Click += btChon_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(496, 8);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Bạn muốn tìm gì";
            // 
            // FrmChonMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmChonMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChonMon";
            Load += FrmChonMon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChonMon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button btThoat;
        private Button btChon;
        private DataGridView dgvChonMon;
    }
}
