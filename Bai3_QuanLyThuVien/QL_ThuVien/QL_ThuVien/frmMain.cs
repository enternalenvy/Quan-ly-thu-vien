using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTaiLieu_Click(object sender, EventArgs e)
        {
            frmTAILIEU frm = new frmTAILIEU();
            frm.Show();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
}
