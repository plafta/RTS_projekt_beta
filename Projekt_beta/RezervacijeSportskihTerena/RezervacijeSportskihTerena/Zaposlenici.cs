using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervacijeSportskihTerena
{
    public partial class frmZaposlenici : Form
    {

        //Referenca na postojeći tim.
        private Zaposlenik zaposlenik = null;

        /// <summary>
        /// Konstruktor forme koji pozivam kada kreiram novi tim.
        /// </summary>
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme koji pozivam kada mijenjam postojećeg zaposlenika.
        /// </summary>
        /// <param name="odabraniTim">Postojeći zaposlenik čije podatke mijenjam.</param>
       /* public frmZaposlenici(Zaposlenik odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = odabraniZaposlenik;
        }*/

        private void btnSpremiZ_Click(object sender, EventArgs e)
        {
            if (zaposlenik == null)
            {
                zaposlenik = new Zaposlenik();
            }
            zaposlenik.imeZaposlenik = txtImeZaposlenik.Text;
            zaposlenik.prezimeZaposlenik = txtPrezZaposlenik.Text;
            zaposlenik.korisnickoIme = txtKorisnickoIme.Text;
            zaposlenik.lozinka = txtLozinka.Text;
            zaposlenik.email = txtEmail.Text;
            zaposlenik.Spremi();
            this.Close();
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme. Ako se radi o izmjeni postojećeg
        /// zaposlenika, tada se kontrole popunjavaju s postojećim podacima.
        /// </summary>
        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            txtImeZaposlenik.Focus();
            if (zaposlenik != null)
            {
                txtIdZaposlenik.Text = zaposlenik.Id.ToString();
                txtImeZaposlenik.Text = zaposlenik.imeZaposlenik;
                txtPrezZaposlenik.Text = zaposlenik.prezimeZaposlenik;
                txtKorisnickoIme.Text = zaposlenik.korisnickoIme;
                txtLozinka.Text = zaposlenik.lozinka;
                txtEmail.Text = zaposlenik.email;
            }
        }

        private void txtImeZaposlenik_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
