namespace RezervacijeSportskihTerena
{
    partial class ZaposleniciPregled
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
            this.components = new System.ComponentModel.Container();
            this.dgvZaposlenik = new System.Windows.Forms.DataGridView();
            this.idZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnickoImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsgZaposlenici = new RezervacijeSportskihTerena.dsgZaposlenici();
            this.zaposlenikTableAdapter = new RezervacijeSportskihTerena.dsgZaposleniciTableAdapters.ZaposlenikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsgZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenik
            // 
            this.dgvZaposlenik.AutoGenerateColumns = false;
            this.dgvZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZaposlenikDataGridViewTextBoxColumn,
            this.imeZaposlenikDataGridViewTextBoxColumn,
            this.prezimeZaposlenikDataGridViewTextBoxColumn,
            this.korisnickoImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvZaposlenik.DataSource = this.zaposlenikBindingSource;
            this.dgvZaposlenik.Location = new System.Drawing.Point(18, 20);
            this.dgvZaposlenik.Name = "dgvZaposlenik";
            this.dgvZaposlenik.Size = new System.Drawing.Size(645, 245);
            this.dgvZaposlenik.TabIndex = 0;
            // 
            // idZaposlenikDataGridViewTextBoxColumn
            // 
            this.idZaposlenikDataGridViewTextBoxColumn.DataPropertyName = "IdZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.HeaderText = "IdZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.Name = "idZaposlenikDataGridViewTextBoxColumn";
            this.idZaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeZaposlenikDataGridViewTextBoxColumn
            // 
            this.imeZaposlenikDataGridViewTextBoxColumn.DataPropertyName = "imeZaposlenik";
            this.imeZaposlenikDataGridViewTextBoxColumn.HeaderText = "imeZaposlenik";
            this.imeZaposlenikDataGridViewTextBoxColumn.Name = "imeZaposlenikDataGridViewTextBoxColumn";
            // 
            // prezimeZaposlenikDataGridViewTextBoxColumn
            // 
            this.prezimeZaposlenikDataGridViewTextBoxColumn.DataPropertyName = "prezimeZaposlenik";
            this.prezimeZaposlenikDataGridViewTextBoxColumn.HeaderText = "prezimeZaposlenik";
            this.prezimeZaposlenikDataGridViewTextBoxColumn.Name = "prezimeZaposlenikDataGridViewTextBoxColumn";
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            this.korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.HeaderText = "korisnickoIme";
            this.korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "Zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.dsgZaposlenici;
            // 
            // dsgZaposlenici
            // 
            this.dsgZaposlenici.DataSetName = "dsgZaposlenici";
            this.dsgZaposlenici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novi unos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZaposleniciPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvZaposlenik);
            this.Name = "ZaposleniciPregled";
            this.Text = "ZaposleniciPregled";
            this.Load += new System.EventHandler(this.ZaposleniciPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsgZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenik;
        private dsgZaposlenici dsgZaposlenici;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private dsgZaposleniciTableAdapters.ZaposlenikTableAdapter zaposlenikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeZaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeZaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}