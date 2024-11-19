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
using DAL;
using DTO;

namespace GUI
{
    public partial class FrmChonMon : Form
    {
        private FrmChonMonBLL frmChonMonBLL;
        public DataGridView thucdon;
        private DataGridViewRow row;
        public FrmChonMon()
        {
            InitializeComponent();
            frmChonMonBLL = new BLL.FrmChonMonBLL();
        }
        private void FrmChonMon_Load(object sender, EventArgs e)
        {
            LoadMenuData();
        }
        private void LoadMenuData()
        {
            DataTable table = frmChonMonBLL.GetMenu();
            dgvChonMon.DataSource = table;
            dgvChonMon.Columns[0].HeaderText = "Mã thực đơn";
            dgvChonMon.Columns[1].HeaderText = "Tên thực đơn";
            dgvChonMon.Columns[2].HeaderText = "Giá";
            if (dgvChonMon.Rows.Count > 0)
            {
                row = dgvChonMon.Rows[0];
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row2 = new DataGridViewRow();

            row2.Cells.Add(new DataGridViewTextBoxCell { Value = row.Cells[0].Value });
            row2.Cells.Add(new DataGridViewTextBoxCell { Value = row.Cells[1].Value });
            row2.Cells.Add(new DataGridViewTextBoxCell { Value = row.Cells[2].Value });
            row2.Cells.Add(new DataGridViewTextBoxCell { Value = 1 });
            thucdon.Rows.Add(row2);
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChonMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgvChonMon.Rows[e.RowIndex];
            }
        }
    }
}
