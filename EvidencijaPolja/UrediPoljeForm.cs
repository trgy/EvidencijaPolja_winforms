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
    public partial class UrediPoljeForm : Form
    {
        public UrediPoljeForm()
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

            imePoljaLabel.Text = "Ime polja: " + DetaljiPoljaForm.imePolja; ;


           
           

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
                    DetaljiPoljaForm.imePolja = dtrPolja.GetString(dtrPolja.GetOrdinal("ImePolja"));
                    lokacijaPolja = dtrPolja.GetString(dtrPolja.GetOrdinal("LokacijaPolja"));
                    povrsinaPolja = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("PovrsinaPolja"));
                    tipZitarice = dtrPolja.GetString(dtrPolja.GetOrdinal("TipZitarice"));
                    gnojivo = dtrPolja.GetString(dtrPolja.GetOrdinal("Gnojivo"));
                    pesticidi = dtrPolja.GetString(dtrPolja.GetOrdinal("Pesticidi"));
                    herbicidi = dtrPolja.GetString(dtrPolja.GetOrdinal("Herbicidi"));
                    gorivo = dtrPolja.GetString(dtrPolja.GetOrdinal("Gorivo"));
                    DetaljiPoljaForm.trosakSjemena = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakSjemena"));
                    DetaljiPoljaForm.trosakGnojiva = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakGnojiva"));
                    DetaljiPoljaForm.trosakSpriceva = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakSpriceva"));
                    DetaljiPoljaForm.trosakGoriva = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("TrosakGoriva"));
                    DetaljiPoljaForm.ostaliTroskovi = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("OstaliTroskovi"));
                    DetaljiPoljaForm.prinos = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("Prinos"));
                    DetaljiPoljaForm.cijenaOtkupa = dtrPolja.GetDecimal(dtrPolja.GetOrdinal("CijenaOtkupa"));
                }
                imePoljaLabel.Text = "Ime polja: " + DetaljiPoljaForm.imePolja;
                lokacijaPoljaTextBox.Text = lokacijaPolja;
                povrsinaPoljaTextBox.Text = povrsinaPolja.ToString();
                tipZitariceTextBox.Text = tipZitarice;
                potrosenoGnojivoTextBox.Text = gnojivo;
                pesticidiTextBox.Text = pesticidi;
                herbicidiTextBox.Text = herbicidi;
                potrosenoGorivoTextBox.Text = gorivo;
                troskoviSjemeTextBox.Text = DetaljiPoljaForm.trosakSjemena.ToString();
                troskoviGnojivoTextBox.Text = DetaljiPoljaForm.trosakGnojiva.ToString();
                troskoviSpricTextBox.Text = DetaljiPoljaForm.trosakSpriceva.ToString();
                troskoviGorivoTextBox.Text = DetaljiPoljaForm.trosakGoriva.ToString();
                ostaliTroskoviTextBox.Text = DetaljiPoljaForm.ostaliTroskovi.ToString();
                prinosTextBox.Text = DetaljiPoljaForm.prinos.ToString();
                cijenaOtkupaTextBox.Text = DetaljiPoljaForm.cijenaOtkupa.ToString();

                dtrPolja.Close();
            }
            catch (System.InvalidCastException)
            {

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Greška u unosu");
            }
        }

        private void odjavaLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
            LoginForm.userId = 0;
            GodineForm.godinaId = 0;
            PoljaForm.poljeId = 0;
        }

        private void natragButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DetaljiPoljaForm dp = new DetaljiPoljaForm();
            dp.Show();
        }

        private void spremiPromjeneButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlCommand scLokacijaPolja = new SqlCommand("UPDATE [Polje] SET [LokacijaPolja]='" + lokacijaPoljaTextBox.Text + "' WHERE [PoljeId]='"+ PoljaForm.poljeId +"'", con);
            SqlCommand scPovrsinaPolja = new SqlCommand("UPDATE [Polje] SET [PovrsinaPolja]='" + povrsinaPoljaTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scTipZitarice = new SqlCommand("UPDATE [Polje] SET [TipZitarice]='" + tipZitariceTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scPotrosenoGnojivo = new SqlCommand("UPDATE [Polje] SET [Gnojivo]='" + potrosenoGnojivoTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scPesticidi = new SqlCommand("UPDATE [Polje] SET [Pesticidi]='" + pesticidiTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scHerbicidi = new SqlCommand("UPDATE [Polje] SET [Herbicidi]='" + herbicidiTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scGorivo = new SqlCommand("UPDATE [Polje] SET [Gorivo]='" + potrosenoGorivoTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scTroskoviSjeme = new SqlCommand("UPDATE [Polje] SET [TrosakSjemena]='" + troskoviSjemeTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scTroskoviGnojivo = new SqlCommand("UPDATE [Polje] SET [TrosakGnojiva]='" + troskoviGnojivoTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scTroskoviSpriceva = new SqlCommand("UPDATE [Polje] SET [TrosakSpriceva]='" + troskoviSpricTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scTroskoviGorivo = new SqlCommand("UPDATE [Polje] SET [TrosakGoriva]='" + troskoviGorivoTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scOstaliTroskovi = new SqlCommand("UPDATE [Polje] SET [OstaliTroskovi]='" + ostaliTroskoviTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scPrinos = new SqlCommand("UPDATE [Polje] SET [Prinos]='" + prinosTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
            SqlCommand scCijenaOtkupa = new SqlCommand("UPDATE [Polje] SET [CijenaOtkupa]='" + cijenaOtkupaTextBox.Text + "' WHERE [PoljeId]='" + PoljaForm.poljeId + "'", con);
         
            try
            {
                con.Open();
                scLokacijaPolja.ExecuteNonQuery();
                scPovrsinaPolja.ExecuteNonQuery();
                scTipZitarice.ExecuteNonQuery();
                scPotrosenoGnojivo.ExecuteNonQuery();
                scPesticidi.ExecuteNonQuery();
                scHerbicidi.ExecuteNonQuery();
                scGorivo.ExecuteNonQuery();
                scTroskoviSjeme.ExecuteNonQuery();
                scTroskoviGnojivo.ExecuteNonQuery();
                scTroskoviSpriceva.ExecuteNonQuery();
                scTroskoviGorivo.ExecuteNonQuery();
                scOstaliTroskovi.ExecuteNonQuery();
                scPrinos.ExecuteNonQuery();
                scCijenaOtkupa.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Promjene spremljene!");
                this.Close();
                DetaljiPoljaForm dp = new DetaljiPoljaForm();
                dp.Show();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Greška prilikom unosa!");
            }

            
        }
    }
}
