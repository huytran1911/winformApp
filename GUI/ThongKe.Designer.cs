﻿namespace GUI
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
            btnThongKe = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            btnTinh1 = new Button();
            btnTinh2 = new Button();
            textNgay = new TextBox();
            textThang = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(0, 140);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(1048, 234);
            dgvThongKe.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(421, 93);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(173, 27);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Segoe UI", 7F);
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(50, 91);
            dateTimePickerStart.Margin = new Padding(2, 3, 2, 3);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(277, 27);
            dateTimePickerStart.TabIndex = 5;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 7F);
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(713, 91);
            dateTimePickerEnd.Margin = new Padding(2, 3, 2, 3);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(277, 27);
            dateTimePickerEnd.TabIndex = 6;
            // 
            // btnTinh1
            // 
            btnTinh1.Location = new Point(275, 413);
            btnTinh1.Name = "btnTinh1";
            btnTinh1.Size = new Size(151, 27);
            btnTinh1.TabIndex = 7;
            btnTinh1.Text = "Tính";
            btnTinh1.UseVisualStyleBackColor = true;
            btnTinh1.Click += btnTinh1_Click;
            // 
            // btnTinh2
            // 
            btnTinh2.Location = new Point(275, 482);
            btnTinh2.Name = "btnTinh2";
            btnTinh2.Size = new Size(151, 27);
            btnTinh2.TabIndex = 8;
            btnTinh2.Text = "Tính";
            btnTinh2.UseVisualStyleBackColor = true;
            btnTinh2.Click += btnTinh2_Click;
            // 
            // textNgay
            // 
            textNgay.Location = new Point(766, 413);
            textNgay.Name = "textNgay";
            textNgay.Size = new Size(209, 27);
            textNgay.TabIndex = 9;
            // 
            // textThang
            // 
            textThang.Location = new Point(766, 482);
            textThang.Name = "textThang";
            textThang.Size = new Size(209, 27);
            textThang.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 420);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 11;
            label2.Text = "Tính Tổng Doanh Thu Theo Ngày ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 489);
            label3.Name = "label3";
            label3.Size = new Size(233, 20);
            label3.TabIndex = 12;
            label3.Text = "Tính Tổng Doanh Thu Theo Tháng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(981, 416);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 13;
            label4.Text = "VNĐ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(981, 482);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 14;
            label5.Text = "VNĐ";
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 546);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textThang);
            Controls.Add(textNgay);
            Controls.Add(btnTinh2);
            Controls.Add(btnTinh1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(btnThongKe);
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
        private Button btnThongKe;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button btnTinh1;
        private Button btnTinh2;
        private TextBox textNgay;
        private TextBox textThang;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}