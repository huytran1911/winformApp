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

namespace GUI
{
    public partial class QLMenu : Form
    {
        public QLMenu()
        {
            InitializeComponent();
        }

        private MenuBLL menuBLL = new MenuBLL();



        private void QLMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void LoadMenu()
        {
            dgvMenu.DataSource = menuBLL.GetAllMenu();
            dgvMenu.Columns[0].HeaderText = "Mã thực đơn";
            dgvMenu.Columns[1].HeaderText = "Tên thực đơn";
            dgvMenu.Columns[2].HeaderText = "Giá";
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
            MenuDTO menu = new MenuDTO(tbMaThucDon.Text, tbTenThucDon.Text, float.Parse(tbGia.Text));
            if (menuBLL.AddMenu(menu))
            {
                MessageBox.Show("Thêm thành công!");
                LoadMenu();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            MenuDTO menu = new MenuDTO(tbMaThucDon.Text, tbTenThucDon.Text, float.Parse(tbGia.Text));
            if (menuBLL.EditMenu(menu))
            {
                MessageBox.Show("Sửa thành công!");
                LoadMenu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (menuBLL.RemoveMenu(tbMaThucDon.Text))
            {
                MessageBox.Show("Xóa thành công!");
                LoadMenu();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
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
