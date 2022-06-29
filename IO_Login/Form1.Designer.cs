
namespace IO_Login
{
    partial class frmHome
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regristrierungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEingabePasswort = new System.Windows.Forms.Label();
            this.lblEingabeKundenNr = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEingabeKundenNr = new System.Windows.Forms.TextBox();
            this.txtEingabePasswort = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 45);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // regristrierungToolStripMenuItem
            // 
            this.regristrierungToolStripMenuItem.Name = "regristrierungToolStripMenuItem";
            this.regristrierungToolStripMenuItem.Size = new System.Drawing.Size(218, 45);
            this.regristrierungToolStripMenuItem.Text = "Registrierung";
            this.regristrierungToolStripMenuItem.Click += new System.EventHandler(this.regristrierungToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.60422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.39578F));
            this.tableLayoutPanel1.Controls.Add(this.lblEingabeKundenNr, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLogin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEingabePasswort, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEingabeKundenNr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEingabePasswort, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 229);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.51419F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.48581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1233, 653);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(442, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(142, 55);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblEingabePasswort
            // 
            this.lblEingabePasswort.AutoSize = true;
            this.lblEingabePasswort.Location = new System.Drawing.Point(3, 282);
            this.lblEingabePasswort.Name = "lblEingabePasswort";
            this.lblEingabePasswort.Size = new System.Drawing.Size(139, 32);
            this.lblEingabePasswort.TabIndex = 1;
            this.lblEingabePasswort.Text = "Passwort:";
            // 
            // lblEingabeKundenNr
            // 
            this.lblEingabeKundenNr.AutoSize = true;
            this.lblEingabeKundenNr.Location = new System.Drawing.Point(3, 174);
            this.lblEingabeKundenNr.Name = "lblEingabeKundenNr";
            this.lblEingabeKundenNr.Size = new System.Drawing.Size(151, 32);
            this.lblEingabeKundenNr.TabIndex = 2;
            this.lblEingabeKundenNr.Text = "KundenNr:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(442, 401);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(444, 119);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnRegistrierung_Click);
            // 
            // txtEingabeKundenNr
            // 
            this.txtEingabeKundenNr.Location = new System.Drawing.Point(442, 177);
            this.txtEingabeKundenNr.Name = "txtEingabeKundenNr";
            this.txtEingabeKundenNr.Size = new System.Drawing.Size(619, 38);
            this.txtEingabeKundenNr.TabIndex = 4;
            // 
            // txtEingabePasswort
            // 
            this.txtEingabePasswort.Location = new System.Drawing.Point(442, 285);
            this.txtEingabePasswort.Name = "txtEingabePasswort";
            this.txtEingabePasswort.Size = new System.Drawing.Size(619, 38);
            this.txtEingabePasswort.TabIndex = 5;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 1146);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kino-Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regristrierungToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEingabeKundenNr;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEingabePasswort;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEingabeKundenNr;
        private System.Windows.Forms.TextBox txtEingabePasswort;
    }
}

