using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IO_Login
{
    public partial class frmRegristrierung : Form
    { 
        private const string PATH = @"..\..\DatenLogin.txt";
        Random rnd = new Random();
        public frmRegristrierung()
        {
            InitializeComponent();
        }
        private void frmRegristrierung_Load(object sender, EventArgs e)
        {
            regristrierungToolStripMenuItem.Enabled = false;

        }



        private void btnRegristrieren_Click(object sender, EventArgs e)
            {
                btnRegistrieren.Enabled = false;
                string Name = txtName.Text + ';';
                string Vorname = txtVorname.Text + ';';
                string BDay = dtpBDay.Text + ';';
                string KreditNr = txtKredikkartennr.Text + ';';
                string txtDatei = Name += Vorname += BDay += KreditNr;

                File.AppendAllText(PATH, txtDatei);

                passwortGenerator();
                KundenNrGenerator();
                File.AppendAllText(PATH, txtAusgabeKundenNr.Text + ";");
                File.AppendAllText(PATH, txtAusgabePasswort.Text + Environment.NewLine);
            }


         public void KundenNrGenerator()
            {
                txtAusgabeKundenNr.Text = "";
                for (int j = 0; j < 2; j++)
                {


                    int randomInt = (int)rnd.Next(0, 10);
                txtAusgabeKundenNr.Text += randomInt;
                }

                txtAusgabeKundenNr.Text += "-";
                for (int i = 0; i < 6; i++)
                {
                    char randomChar = (char)rnd.Next('a', 'z');
                    txtAusgabeKundenNr.Text += randomChar;
                }

            }

            public void passwortGenerator()
            {
                txtAusgabePasswort.Text = "";
                for (int i = 0; i < 6; i++)
                {
                    int randomPasswort = (int)rnd.Next(1, 10);
                    txtAusgabePasswort.Text += Convert.ToString(randomPasswort);
                }

            }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHome().Show();
        }
    }
    
}


