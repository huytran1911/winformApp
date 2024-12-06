﻿using System;
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
        public DataTable danhSachMon;
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
            DataRow row2 = danhSachMon.NewRow();
            row2["STT"] = danhSachMon.Rows.Count + 1;
            row2["Thực Đơn"] = row.Cells[1].Value;
            row2["Đơn Giá"] =  row.Cells[2].Value ;
            row2["SL"] = 1 ;
            row2["Ghi Chú"] = "";
            danhSachMon.Rows.Add(row2);
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
