namespace GUI
{
    partial class ThongKe
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
            label1 = new Label();
            dgvThongKe = new DataGridView();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            btnThongKe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 21);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 0;
            label1.Text = "Thống Kê";
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(0, 140);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(1048, 355);
            dgvThongKe.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(36, 93);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(270, 27);
            dtpFromDate.TabIndex = 2;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(711, 93);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(270, 27);
            dtpToDate.TabIndex = 3;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(421, 93);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(173, 27);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 546);
            Controls.Add(btnThongKe);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(dgvThongKe);
            Controls.Add(label1);
            Name = "ThongKe";
            Text = "ThongKe";
            Load += ThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvThongKe;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnThongKe;
    }
}