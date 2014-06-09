using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RezervacijeSportskihTerena
{
    /// <summary>
    /// Klasa za pristup bazi podataka.
    /// </summary>
    public class DB
    {
        #region Private Fields
 
        private string connectionString;
        private SqlConnection connection;
        private static DB instance;
 
        #endregion

        #region Properties
 
        /// <summary>
        /// Putanja i ostali parametri za spajanje na bazu podataka.
        /// </summary>
        public string ConnectionString
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }

        /// <summary>
        /// Konekcija prema bazi podataka.
        /// </summary>
        public SqlConnection Connection
        {
            get { return connection; }
            private set { connection = value; }
        }

        /// <summary>
        /// Singleton instanca klase za rad sa bazom podataka.
        /// </summary>
        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        #endregion
 
        #region Constructors
 
        /// <summary>
        /// Privatni konstruktor klase potreban za singleton implementaciju.
        /// </summary>
        private DB()
        {
            ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Martin\Desktop\Projekt_beta\RezervacijeSportskihTerena\RezervacijeSportskihTerena\Baza\RTS_DB.mdf;Integrated Security=True;Connect Timeout=10";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }
 
        /// <summary>
        /// Destruktor klase.
        /// </summary>
        ~DB()
        {
            Connection.Close();
            Connection = null;
        }
 
        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju prosljeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Rezultat upita.</returns>
        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Dohvaća skalarnu vrijednost na temelju prosljeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        /// <summary>
        /// Izvršava prosljeđeni SQL izraz (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="sqlUpit">SQL izraz.</param>
        /// <returns>Broj redaka koji su promijenjeni.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }

        #endregion

    }
}
