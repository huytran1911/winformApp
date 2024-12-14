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
            string maThucDon = tbMaThucDon.Text;
            string tenThucDon = tbTenThucDon.Text;
            float gia = float.Parse(tbGia.Text);
            

            if (menuBLL.KiemTraThongTinHopLe(maThucDon,tenThucDon,gia))
            {
                if (menuDAL.ThemMenu(maThucDon, tenThucDon, gia))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ.");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow != null)
            {


                // Lấy các giá trị khác từ giao diện
                string maThucDon = tbMaThucDon.Text;
                string tenThucDon = tbTenThucDon.Text;
                float gia = float.Parse(tbGia.Text);

                // Kiểm tra thông tin hợp lệ
                if (menuBLL.KiemTraThongTinHopLe(maThucDon, tenThucDon, gia))
                {
                    // Lấy mã nhân viên từ DataGridView
                    string maThucDonBD = dgvMenu.CurrentRow.Cells["MaNhanVien"].Value.ToString() ?? string.Empty;
                    string maThucDonHT = tbMaThucDon.Text;

                    // Kiểm tra nếu mã nhân viên đã bị thay đổi
                    if (maThucDonBD != maThucDonHT)
                    {
                        MessageBox.Show("Mã nhân viên không được thay đổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Thực hiện cập nhật thông tin nhân viên
                    if (menuDAL.SuaMenu(maThucDon, tenThucDon, gia))
                    {
                        MessageBox.Show("Sửa nhân viên thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi sửa nhân viên.");
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ.");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow != null)
            {
                string maThucDon =   dgvMenu.CurrentRow.Cells["MaThucDon"].Value?.ToString() ?? string.Empty;
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