using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IO_Login
{
    public partial class frmHome : Form
    {
        private const string PATH = @"..\..\DatenLogin.txt";
        public frmHome()
        {
            InitializeComponent();
            loginToolStripMenuItem.Enabled = false;
        }


        private void regristrierungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new frmRegristrierung().Show();

        }

        private void btnRegistrierung_Click(object sender, EventArgs e)
        {
           string KundenNr = txtEingabeKundenNr.Text;
           string Passwort = txtEingabePasswort.Text;

            foreach (string line in File.ReadLines(PATH))
            {
                if (KundenNr == line.Split(';')[4] && Passwort == line.Split(';')[5])
                {
                    new frmKaufReservierung().Show();
                    this.Hide();
                }
                else
                {
                    lblLogin.Text = "Anmeldung nicht möglich,\r\n" +
                        "Bitte überprüfen Sie Ihre Daten.";
                }
            }
        }
    }
}
