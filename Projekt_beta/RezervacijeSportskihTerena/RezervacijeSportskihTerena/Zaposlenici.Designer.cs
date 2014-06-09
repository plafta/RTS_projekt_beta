namespace RezervacijeSportskihTerena
{
    partial class frmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImeZaposlenik = new System.Windows.Forms.TextBox();
            this.txtPrezZaposlenik = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSpremiZ = new System.Windows.Forms.Button();
            this.txtIdZaposlenik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime zaposlenika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime zaposlenika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisnicko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // txtImeZaposlenik
            // 
            this.txtImeZaposlenik.Location = new System.Drawing.Point(124, 28);
            this.txtImeZaposlenik.Name = "txtImeZaposlenik";
            this.txtImeZaposlenik.Size = new System.Drawing.Size(148, 20);
            this.txtImeZaposlenik.TabIndex = 5;
            this.txtImeZaposlenik.TextChanged += new System.EventHandler(this.txtImeZaposlenik_TextChanged);
            // 
            // txtPrezZaposlenik
            // 
            this.txtPrezZaposlenik.Location = new System.Drawing.Point(124, 63);
            this.txtPrezZaposlenik.Name = "txtPrezZaposlenik";
            this.txtPrezZaposlenik.Size = new System.Drawing.Size(148, 20);
            this.txtPrezZaposlenik.TabIndex = 6;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(124, 96);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(148, 20);
            this.txtKorisnickoIme.TabIndex = 7;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(124, 132);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(148, 20);
            this.txtLozinka.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnSpremiZ
            // 
            this.btnSpremiZ.Location = new System.Drawing.Point(104, 211);
            this.btnSpremiZ.Name = "btnSpremiZ";
            this.btnSpremiZ.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiZ.TabIndex = 10;
            this.btnSpremiZ.Text = "Spremi";
            this.btnSpremiZ.UseVisualStyleBackColor = true;
            this.btnSpremiZ.Click += new System.EventHandler(this.btnSpremiZ_Click);
            // 
            // txtIdZaposlenik
            // 
            this.txtIdZaposlenik.Location = new System.Drawing.Point(133, 2);
            this.txtIdZaposlenik.Name = "txtIdZaposlenik";
            this.txtIdZaposlenik.Size = new System.Drawing.Size(100, 20);
            this.txtIdZaposlenik.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IdZaposlenik";
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdZaposlenik);
            this.Controls.Add(this.btnSpremiZ);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtPrezZaposlenik);
            this.Controls.Add(this.txtImeZaposlenik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImeZaposlenik;
        private System.Windows.Forms.TextBox txtPrezZaposlenik;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSpremiZ;
        private System.Windows.Forms.TextBox txtIdZaposlenik;
        private System.Windows.Forms.Label label6;
    }
}