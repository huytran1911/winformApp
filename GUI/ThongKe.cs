using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    using BLL;
    using DTO;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class ThongKe : Form
    {

        public ThongKe()
        {
            InitializeComponent();
        }
        private ThongKeBLL thongkeBLL = new ThongKeBLL();

        private void LoadThongKe()
        {
            dgvThongKe.DataSource = thongkeBLL.GetAllThongKe();

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ hai DateTimePicker
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            // Kiểm tra logic thời gian (endDate phải lớn hơn startDate)
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc dữ liệu và hiển thị lên DataGridView
            DataTable dtThongKe = thongkeBLL.FilterThongKeByDate(startDate, endDate);
            dgvThongKe.DataSource = dtThongKe;

            if (dtThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void btnTinh1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerStart.Value.Date;

            // Gọi phương thức tính tổng doanh thu theo ngày
            decimal totalRevenue = thongkeBLL.GetTotalRevenueByDay(selectedDate);

            // Hiển thị doanh thu trên TextBox mà không có ký hiệu tiền tệ
            textNgay.Text = totalRevenue.ToString("N0");  // "N0" format will display number without currency symbol
        }

        private void btnTinh2_Click(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ DateTimePicker
            DateTime selectedDate = dateTimePickerStart.Value.Date;

            // Gọi phương thức tính tổng doanh thu theo tháng
            decimal totalRevenue = thongkeBLL.GetTotalRevenueByMonth(selectedDate);

            // Hiển thị doanh thu trên TextBox mà không có ký hiệu tiền tệ
            textThang.Text = totalRevenue.ToString("N0");  // "N0" format will display number without currency symbol
        }

        private void btnTinh3_Click(object sender, EventArgs e)
        {
            // Step 1: Get the selected month and year from DateTimePicker
            DateTime selectedMonth = comboBoxDatePicker.Value; // Ensure it's set to show month/year

            // Step 2: Call the BLL method to calculate revenue for the selected month
            decimal previousRevenue = thongkeBLL.GetPreviousRevenueByMonth(selectedMonth);

            // Step 3: Display revenue in the TextBox
            textDoanhThuTruoc.Text = previousRevenue.ToString("N0"); // Format as number
        }
    }
}
