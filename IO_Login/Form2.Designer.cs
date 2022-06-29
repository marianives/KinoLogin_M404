
namespace IO_Login
{
    partial class frmRegristrierung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKredikkartennr = new System.Windows.Forms.TextBox();
            this.dtpBDay = new System.Windows.Forms.DateTimePicker();
            this.lblKreditkartennummer = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.lblBDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regristrierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAusgabePasswort = new System.Windows.Forms.TextBox();
            this.txtAusgabeKundenNr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.21128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.78872F));
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRegistrieren, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtKredikkartennr, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpBDay, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblKreditkartennummer, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblVorname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtVorname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBDay, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtAusgabePasswort, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtAusgabeKundenNr, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(355, 197);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.70642F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.29358F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(833, 846);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 32);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.Location = new System.Drawing.Point(237, 281);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(483, 66);
            this.btnRegistrieren.TabIndex = 17;
            this.btnRegistrieren.Text = "Registrieren";
            this.btnRegistrieren.UseVisualStyleBackColor = true;
            this.btnRegistrieren.Click += new System.EventHandler(this.btnRegristrieren_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(483, 38);
            this.txtName.TabIndex = 13;
            // 
            // txtKredikkartennr
            // 
            this.txtKredikkartennr.Location = new System.Drawing.Point(237, 212);
            this.txtKredikkartennr.Name = "txtKredikkartennr";
            this.txtKredikkartennr.Size = new System.Drawing.Size(483, 38);
            this.txtKredikkartennr.TabIndex = 14;
            // 
            // dtpBDay
            // 
            this.dtpBDay.Location = new System.Drawing.Point(237, 139);
            this.dtpBDay.Name = "dtpBDay";
            this.dtpBDay.Size = new System.Drawing.Size(483, 38);
            this.dtpBDay.TabIndex = 16;
            // 
            // lblKreditkartennummer
            // 
            this.lblKreditkartennummer.AutoSize = true;
            this.lblKreditkartennummer.Location = new System.Drawing.Point(3, 209);
            this.lblKreditkartennummer.Name = "lblKreditkartennummer";
            this.lblKreditkartennummer.Size = new System.Drawing.Size(228, 32);
            this.lblKreditkartennummer.TabIndex = 12;
            this.lblKreditkartennummer.Text = "Kreditkarten Nr. :";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(3, 65);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(138, 32);
            this.lblVorname.TabIndex = 10;
            this.lblVorname.Text = "Vorname:";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(237, 68);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(483, 38);
            this.txtVorname.TabIndex = 15;
            // 
            // lblBDay
            // 
            this.lblBDay.AutoSize = true;
            this.lblBDay.Location = new System.Drawing.Point(3, 136);
            this.lblBDay.Name = "lblBDay";
            this.lblBDay.Size = new System.Drawing.Size(203, 32);
            this.lblBDay.TabIndex = 11;
            this.lblBDay.Text = "Geburtsdatum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ihr Passwort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ihre Kunden Nr. :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.regristrierungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1542, 49);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 45);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // regristrierungToolStripMenuItem
            // 
            this.regristrierungToolStripMenuItem.Name = "regristrierungToolStripMenuItem";
            this.regristrierungToolStripMenuItem.Size = new System.Drawing.Size(218, 45);
            this.regristrierungToolStripMenuItem.Text = "Registrierung";
            // 
            // txtAusgabePasswort
            // 
            this.txtAusgabePasswort.Location = new System.Drawing.Point(237, 434);
            this.txtAusgabePasswort.Name = "txtAusgabePasswort";
            this.txtAusgabePasswort.ReadOnly = true;
            this.txtAusgabePasswort.Size = new System.Drawing.Size(483, 38);
            this.txtAusgabePasswort.TabIndex = 24;
            // 
            // txtAusgabeKundenNr
            // 
            this.txtAusgabeKundenNr.Location = new System.Drawing.Point(237, 480);
            this.txtAusgabeKundenNr.Name = "txtAusgabeKundenNr";
            this.txtAusgabeKundenNr.ReadOnly = true;
            this.txtAusgabeKundenNr.Size = new System.Drawing.Size(483, 38);
            this.txtAusgabeKundenNr.TabIndex = 26;
            // 
            // frmRegristrierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 1146);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmRegristrierung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regristrierung";
            this.Load += new System.EventHandler(this.frmRegristrierung_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKredikkartennr;
        private System.Windows.Forms.DateTimePicker dtpBDay;
        private System.Windows.Forms.Label lblKreditkartennummer;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label lblBDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regristrierungToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAusgabePasswort;
        private System.Windows.Forms.TextBox txtAusgabeKundenNr;
    }
}