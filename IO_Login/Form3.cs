using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Login
{
    public partial class frmKaufReservierung : Form
    {
        public frmKaufReservierung()
        {
            InitializeComponent();
            regristrierungToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmHome().Show();
        }
    }
}
