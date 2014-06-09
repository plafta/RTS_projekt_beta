using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RezervacijeSportskihTerena
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti zaposlenika.
    /// </summary>
    class Zaposlenik
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje novog praznog zaposlenika.
        /// </summary>
        public Zaposlenik()
        {

        }

        /// <summary>
        /// Konstruktor za kreiranje zaposlenika od postojećih podataka iz DataReader-a.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Zaposlenike.</param>
        public Zaposlenik(SqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["IdZaposlenik"].ToString());
                imeZaposlenik = dr["imeZaposlenik"].ToString();
                prezimeZaposlenik = dr["prezimeZaposlenik"].ToString();
                korisnickoIme = dr["korisnickoIme"].ToString();
                lozinka = dr["lozinka"].ToString();
                email = dr["email"].ToString();
            }
        }

        #endregion

        #region Private Fields

        private int id;
        public string imeZaposlenik;
        public string prezimeZaposlenik;
        public string korisnickoIme;
        public string lozinka;
        public string email;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator zaposlenika.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sprema vrijednosti objekta zaposlenik u bazu podataka.
        /// </summary>
        /// <returns>Broj redaka koji su dodani ili izmjenjeni.</returns>
        public int Spremi()
        {
            string sqlUpit = "";

            if (Id == 0)        //Ako se radi o novokreiranom timu tada treba izvršiti INSERT
            {
                sqlUpit = "INSERT INTO Zaposlenik (imeZaposlenik, prezimeZaposlenik, korisnickoIme, lozinka, email) "
                        + "VALUES ('" + imeZaposlenik + "','" + prezimeZaposlenik + "','" + korisnickoIme + "','" + lozinka + "','" + email + "')";
            }
            else                //Ako se radi o izmjeni postojećeg tada treba izvršiti UPDATE
            {
                sqlUpit = "UPDATE Zaposlenik SET imeZaposlenik = '" + imeZaposlenik
                + "', prezimeZaposlenik = '" + prezimeZaposlenik
                + "', korisnickoIme = '" + korisnickoIme
                + "', lozinka = '" + lozinka
                + "', email = '" + email
                + "' WHERE Id = " + Id;
            }

            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        /// <summary>
        /// Briše Tim iz baze podataka.
        /// </summary>
        /// <returns>Broj obrisanih redaka.</returns>
        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Zaposlenik WHERE Id = " + Id;
            return DB.Instance.IzvrsiUpit(sqlDelete);
        }

        /// <summary>
        /// Dohvaća sve zaposlenike iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns><Lista timova.</returns>
        public static List<Zaposlenik> DohvatiZaposlenike()
        {
            List<Zaposlenik> lista = new List<Zaposlenik>();

            string sqlUpit = "SELECT * FROM Zaposlenik";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zaposlenik zaposlenik = new Zaposlenik(dr);
                lista.Add(zaposlenik);
            }
            dr.Close();
            return lista;
        }

        #endregion
    }
}
