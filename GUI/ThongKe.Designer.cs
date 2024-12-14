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
            label6 = new Label();
            textDoanhThuTruoc = new TextBox();
            label7 = new Label();
            btnTinh3 = new Button();
            comboBoxDatePicker = new DateTimePicker();
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
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy ";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(50, 91);
            dateTimePickerStart.Margin = new Padding(2, 3, 2, 3);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(277, 27);
            dateTimePickerStart.TabIndex = 5;
            dateTimePickerStart.Value = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Segoe UI", 7F);
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy ";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(713, 91);
            dateTimePickerEnd.Margin = new Padding(2, 3, 2, 3);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(277, 27);
            dateTimePickerEnd.TabIndex = 6;
            dateTimePickerEnd.Value = new DateTime(2024, 12, 14, 0, 0, 0, 0);
            // 
            // btnTinh1
            // 
            btnTinh1.Location = new Point(275, 392);
            btnTinh1.Name = "btnTinh1";
            btnTinh1.Size = new Size(151, 27);
            btnTinh1.TabIndex = 7;
            btnTinh1.Text = "Tính";
            btnTinh1.UseVisualStyleBackColor = true;
            btnTinh1.Click += btnTinh1_Click;
            // 
            // btnTinh2
            // 
            btnTinh2.Location = new Point(275, 438);
            btnTinh2.Name = "btnTinh2";
            btnTinh2.Size = new Size(151, 27);
            btnTinh2.TabIndex = 8;
            btnTinh2.Text = "Tính";
            btnTinh2.UseVisualStyleBackColor = true;
            btnTinh2.Click += btnTinh2_Click;
            // 
            // textNgay
            // 
            textNgay.Location = new Point(766, 389);
            textNgay.Name = "textNgay";
            textNgay.Size = new Size(209, 27);
            textNgay.TabIndex = 9;
            // 
            // textThang
            // 
            textThang.Location = new Point(766, 441);
            textThang.Name = "textThang";
            textThang.Size = new Size(209, 27);
            textThang.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 396);
            label2.Name = "label2";
            label2.Size = new Size(231, 20);
            label2.TabIndex = 11;
            label2.Text = "Tính Tổng Doanh Thu Theo Ngày ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 441);
            label3.Name = "label3";
            label3.Size = new Size(233, 20);
            label3.TabIndex = 12;
            label3.Text = "Tính Tổng Doanh Thu Theo Tháng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(981, 392);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 13;
            label4.Text = "VNĐ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(981, 445);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 14;
            label5.Text = "VNĐ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 498);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 16;
            label6.Text = "Tính Doanh Thu Trước";
            // 
            // textDoanhThuTruoc
            // 
            textDoanhThuTruoc.Location = new Point(766, 495);
            textDoanhThuTruoc.Name = "textDoanhThuTruoc";
            textDoanhThuTruoc.Size = new Size(209, 27);
            textDoanhThuTruoc.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(981, 495);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 19;
            label7.Text = "VNĐ";
            // 
            // btnTinh3
            // 
            btnTinh3.Location = new Point(472, 498);
            btnTinh3.Name = "btnTinh3";
            btnTinh3.Size = new Size(151, 27);
            btnTinh3.TabIndex = 21;
            btnTinh3.Text = "Tính";
            btnTinh3.UseVisualStyleBackColor = true;
            btnTinh3.Click += btnTinh3_Click;
            // 
            // comboBoxDatePicker
            // 
            comboBoxDatePicker.CustomFormat = "MM/yyyy";
            comboBoxDatePicker.Format = DateTimePickerFormat.Custom;
            comboBoxDatePicker.Location = new Point(198, 498);
            comboBoxDatePicker.Name = "comboBoxDatePicker";
            comboBoxDatePicker.ShowUpDown = true;
            comboBoxDatePicker.Size = new Size(249, 27);
            comboBoxDatePicker.TabIndex = 20;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 546);
            Controls.Add(btnTinh3);
            Controls.Add(comboBoxDatePicker);
            Controls.Add(label7);
            Controls.Add(textDoanhThuTruoc);
            Controls.Add(label6);
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
        private Label label6;
        private TextBox textDoanhThuTruoc;
        private Label label7;
        private Button btnTinh3;
        private DateTimePicker comboBoxDatePicker;
    }
}