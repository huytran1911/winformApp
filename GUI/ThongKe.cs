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
    }

}
