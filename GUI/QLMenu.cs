using BLL;
using DTO;
using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class QLMenu : Form
    {
        private MenuBLL menuBLL = new MenuBLL();
        private MenuDAL menuDAL = new MenuDAL();
        public QLMenu()
        {
            InitializeComponent();
            LoadData();
        }

        

        private void LoadData()
        {
            dgvMenu.DataSource = menuDAL.LayDanhSachMenu();
        }
        private void ResetTextBoxes()
        {
            // Giả sử bạn có các TextBox: txtMaThucDon, txtTenThucDon, txtGia
            tbMaThucDon.Clear();  // Xóa dữ liệu trong TextBox MaThucDon
            tbTenThucDon.Clear(); // Xóa dữ liệu trong TextBox TenThucDon
            tbGia.Clear();        // Xóa dữ liệu trong TextBox Gia
        }


        private void LoadMenu()
        {
            dgvMenu.DataSource = menuBLL.GetAllMenus();
            dgvMenu.Columns[0].HeaderText = "Mã thực đơn";
            dgvMenu.Columns[1].HeaderText = "Tên thực đơn";
            dgvMenu.Columns[2].HeaderText = "Giá";
        }
        private void QLMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
            tbMaThucDon.Text = row.Cells["MaThucDon"].Value.ToString();
            tbTenThucDon.Text = row.Cells["TenThucDon"].Value.ToString();
            tbGia.Text = row.Cells["Gia"].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maThucDon = tbMaThucDon.Text;
                string tenThucDon = tbTenThucDon.Text;
                float gia;

                // Kiểm tra giá trị tbGia.Text có hợp lệ hay không
                if (!float.TryParse(tbGia.Text, out gia))
                {
                    MessageBox.Show("Giá không hợp lệ. Vui lòng nhập số hợp lệ.");
                    return; // Kết thúc sự kiện nếu giá trị không hợp lệ
                }

                if (menuBLL.KiemTraThongTinHopLe(maThucDon, tenThucDon, gia))
                {
                    if (menuDAL.ThemMenu(maThucDon, tenThucDon, gia))
                    {
                        MessageBox.Show("Thêm thực đơn thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm thực đơn.");
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.CurrentRow != null)
                {


                    // Lấy các giá trị khác từ giao diện
                    string maThucDon = tbMaThucDon.Text;
                    string tenThucDon = tbTenThucDon.Text;
                    string gia = tbGia.Text;

                    // Kiểm tra nếu gia không phải là số hợp lệ
                    if (!float.TryParse(gia, out float giaFloat))
                    {
                        MessageBox.Show("Giá không hợp lệ. Vui lòng nhập số hợp lệ.");
                        return; // Kết thúc sự kiện nếu giá trị không hợp lệ
                    }

                    if (menuBLL.KiemTraThongTinHopLe(maThucDon, tenThucDon, giaFloat))
                    {
                        if (menuDAL.ThemMenu(maThucDon, tenThucDon, giaFloat))
                        {
                            MessageBox.Show("Thêm thực đơn thành công!");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi thêm thực đơn.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.CurrentRow != null)
                {
                    string maThucDon = dgvMenu.CurrentRow.Cells["MaThucDon"].Value?.ToString() ?? string.Empty;
                    if (menuDAL.XoaMenu(maThucDon))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên.");
                    }
                }
            }
            catch
            {

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}