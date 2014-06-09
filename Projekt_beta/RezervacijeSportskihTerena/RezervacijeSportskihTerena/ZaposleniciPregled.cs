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
    public partial class ZaposleniciPregled : Form
    {
        public ZaposleniciPregled()
        {
            InitializeComponent();
        }

        private void ZaposleniciPregled_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsgZaposlenici.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.dsgZaposlenici.Zaposlenik);
            //OsvjeziZaposlenike();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmZaposlenici linkNoviUnos = new frmZaposlenici();
            linkNoviUnos.ShowDialog();
            //OsvjeziZaposlenike();
        }

        /// <summary>
        /// Osvježava DataGridView sa popisom zaposlenika.
        /// </summary>
        private void OsvjeziZaposlenike()
        {
            List<Zaposlenik> listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            dgvZaposlenik.DataSource = listaZaposlenika;
        }

    }
}
