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
    public partial class FrmChinhSuaThucDon : Form
    {
        private ThucDonBLL _thucDon;
        public FrmChinhSuaThucDon(ThucDonBLL thucDon)
        {
            InitializeComponent();
            _thucDon = thucDon;
        }

        private void FrmChinhSuaThucDon_Load(object sender, EventArgs e)
        {
            lbThucDon.Text = _thucDon.TenMon;
            tbSoLuong.Text = _thucDon.SoLuong.ToString();
            tbGhiChu.Text = _thucDon.GhiChu;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _thucDon.CapNhatThongTin(tbSoLuong.Text, tbGhiChu.Text);
                this.DialogResult = DialogResult.OK; // Đóng form và trả kết quả thành công
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
