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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void btChonmon_Click(object sender, EventArgs e)
        {
            FrmChonMon frmChonMon = new FrmChonMon();
            frmChonMon.thucdon = dgvThucDon;
            frmChonMon.ShowDialog();
        }
    }
}
