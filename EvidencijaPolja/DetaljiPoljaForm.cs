using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidencijaPolja
{
    public partial class DetaljiPoljaForm : Form
    {
        public static String imePolja = "";

        public static decimal trosakSjemena = 0;
        public static decimal trosakGnojiva = 0;
        public static decimal trosakSpriceva = 0;
        public static decimal trosakGoriva = 0;
        public static decimal ostaliTroskovi = 0;

        public static float dobit = 0;
        public static float ukupniTrosak = 0;
        public static float profit = 0;
        
        public static decimal cijenaOtkupa = 0;  
        public static decimal prinos = 0;
        public DetaljiPoljaForm()
        {
            InitializeComponent();

            String user = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [User] FROM [User] WHERE [UserId]='" + LoginForm.userId + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataTableReader dtr = new DataTableReader(dt);
            while (dtr.Read())
            {
                user = dtr.GetString(dtr.GetOrdinal("User"));
            }
            odjavaLabel.Text = user + " (odjava)";

            dtr.Close();
            godinaLabel.Text = PoljaForm.godina;

            string lokacijaPolja = "";
            decimal povrsinaPolja = 0;
            string tipZitarice = "";
            string gnojivo = "";
            string pesticidi = "";
            string herbicidi = "";
            string gorivo = "";

            try
            {
                SqlDataAdapter sdaPolja = new SqlDataAdapter("SELECT [ImePolja], [LokacijaPolja], [PovrsinaPolja], [TipZitarice], [Gnojivo], [Pesticidi], [Herbicidi], [Gorivo], [TrosakSjemena], [TrosakGnojiva], [TrosakSpriceva], [TrosakGoriva], [OstaliTroskovi], [Prinos], [CijenaOtkupa] FROM [Polje] WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
                DataTable dtPolja = new DataTable();
                sdaPolja.Fill(dtPolja);

                DataTableReader dtrPolja = new DataTableReader(dtPolja);
                while (dtrPolja.Read())
                {
                    imePolja = dtrPolja.GetString(dtrPolja.GetOrdinal("ImePolja"));
                    lokacijaPolja = dtrPolja.GetString(dtrPolja.GetOrdinal("LokacijaPolja"));
                    povrsinaPolja = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("PovrsinaPolja"));
                    tipZitarice = dtrPolja.GetString(dtrPolja.GetOrdinal("TipZitarice"));
                    gnojivo = dtrPolja.GetString(dtrPolja.GetOrdinal("Gnojivo"));
                    pesticidi = dtrPolja.GetString(dtrPolja.GetOrdinal("Pesticidi"));
                    herbicidi = dtrPolja.GetString(dtrPolja.GetOrdinal("Herbicidi"));
                    gorivo = dtrPolja.GetString(dtrPolja.GetOrdinal("Gorivo"));
                    trosakSjemena = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakSjemena"));
                    trosakGnojiva = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakGnojiva"));
                    trosakSpriceva = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakSpriceva"));
                    trosakGoriva = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakGoriva"));
                    ostaliTroskovi = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("OstaliTroskovi"));
                    prinos = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("Prinos"));
                    cijenaOtkupa = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("CijenaOtkupa"));
                }
                imePoljaLabel.Text = "Ime polja: " + imePolja;
                lokacijaPoljaLabel.Text = "Lokacija polja: " + lokacijaPolja;
                povrsinaPoljaLabel.Text = "Površina polja: " + povrsinaPolja.ToString() + " ha";
                tipZitariceLabel.Text = "Tip žitarice: " + tipZitarice;
                potrosenoGnojivoLabel.Text = "Potrošeno gnojivo: " + gnojivo;
                pesticidiLabel.Text = "Pesticidi: " + pesticidi;
                herbicidiLabel.Text = "Herbicidi: " + herbicidi;
                potrosenoGorivoLabel.Text = "Gorivo: " + gorivo;
                troskoviSjemeLabel.Text = "Sjeme = " + trosakSjemena.ToString() + " kn";
                troskoviGnojivoLabel.Text = "Gnojivo = " + trosakGnojiva.ToString() + " kn";
                troskoviSpricLabel.Text = "Špricevi = " + trosakSpriceva.ToString() + " kn";
                troskoviGorivoLabel.Text = "Gorivo = " + trosakGoriva.ToString() + " kn";
                ostaliTroskoviLabel.Text = "Ostali troškovi = " + ostaliTroskovi.ToString() + " kn";
                kolicinaLabel.Text = "Prinos = " + prinos.ToString() + " t";
                cijenaOtkupaLabel.Text = "Cijena = " + cijenaOtkupa.ToString() + " kn/t";

                dtrPolja.Close();
            }
            catch (System.InvalidCastException) 
            { 

            }
                        
                dobit = (float)prinos * (float)cijenaOtkupa;
                dobitLabel.Text = "Dobit = " + dobit.ToString() + " kn";
              
            
                ukupniTrosak = (float)trosakSjemena + (float)trosakGnojiva + (float)trosakSpriceva + (float)trosakGoriva + (float)ostaliTroskovi;
                ukupniTrosakLabel.Text = "Ukupni trošak = " + ukupniTrosak.ToString() + " kn";
                     
          
                profit = dobit - ukupniTrosak;
                profitLabel.Text = "Profit = " + profit.ToString() + " kn";
                   
        }

        private void natragButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PoljaForm pf = new PoljaForm();
            pf.Show();
            PoljaForm.poljeId = 0;
            
            prinos = 0;
            cijenaOtkupa = 0;

            trosakSjemena = 0;
            trosakGnojiva = 0;
            trosakSpriceva = 0;
            trosakGoriva = 0;
            ostaliTroskovi = 0;

            dobit = 0;
            ukupniTrosak = 0;
            profit = 0;
        }

        private void odjavaLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
            LoginForm.userId = 0;
            GodineForm.godinaId = 0;
            PoljaForm.poljeId = 0;

            prinos = 0;
            cijenaOtkupa = 0;

            trosakSjemena = 0;
            trosakGnojiva = 0;
            trosakSpriceva = 0;
            trosakGoriva = 0;
            ostaliTroskovi = 0;

            dobit = 0;
            ukupniTrosak = 0;
            profit = 0;
        }

        private void obrisiPoljeButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlCommand sc = new SqlCommand("DELETE FROM [Polje] WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            con.Open();
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Obrisali ste polje: " + imePolja);
            this.Close();
            PoljaForm pf = new PoljaForm();
            pf.Show();
            PoljaForm.poljeId = 0;

            prinos = 0;
            cijenaOtkupa = 0;

            trosakSjemena = 0;
            trosakGnojiva = 0;
            trosakSpriceva = 0;
            trosakGoriva = 0;
            ostaliTroskovi = 0;

            dobit = 0;
            ukupniTrosak = 0;
            profit = 0;
        }

        private void urediPodatkePoljaButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UrediPoljeForm up = new UrediPoljeForm();
            up.Show();
        }
    }
}
