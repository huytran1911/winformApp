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
            dgvThongKe.Size = new Size(1048, 355);
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
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 546);
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
    }
}