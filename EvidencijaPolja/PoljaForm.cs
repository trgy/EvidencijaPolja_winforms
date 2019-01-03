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
    public partial class PoljaForm : Form
    {
        public static int poljeId = 0;
        public static String godina = "";
        public PoljaForm()
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

            
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT [Godina] FROM [Godina] WHERE [GodinaId]='" + GodineForm.godinaId + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            DataTableReader dtr2 = new DataTableReader(dt2);
            while (dtr2.Read())
            {
                godina = dtr2.GetString(dtr2.GetOrdinal("Godina"));
            }
            godinaLabel.Text = godina;

            dtr2.Close();

            SqlDataAdapter sdaPolja = new SqlDataAdapter("SELECT [ImePolja] FROM [Polje] WHERE [GodinaId]='" + GodineForm.godinaId + "'", con);

            List<object> list = new List<object>();
            DataTable t = new DataTable();
            DataSet s = new DataSet();
            sdaPolja.Fill(s);
            t = s.Tables[0];
            foreach (DataRow c in t.Rows)
            {
                list.Add(c["ImePolja"]);
            }

            poljaListBox.DataSource = list;

            con.Close();
        }

        private void odjavaLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
            LoginForm.userId = 0;
            GodineForm.godinaId = 0;
        }

        private void natragButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GodineForm gf = new GodineForm();
            gf.Show();
        }

        private void obrisiGodinuButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlCommand sc = new SqlCommand("DELETE FROM [Godina] WHERE [GodinaId]='" + GodineForm.godinaId + "'", con);
            SqlCommand sc1 = new SqlCommand("DELETE FROM [Polje] WHERE [GodinaId]='" + GodineForm.godinaId + "'", con);
            con.Open();
            sc1.ExecuteNonQuery();
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Obrisali ste godinu: " + godina + " i sva polja u njoj");
            this.Close();
            GodineForm gf = new GodineForm();
            gf.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");

            con.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO [Polje] ([GodinaId], [ImePolja]) VALUES (@GodinaId, @ImePolja)", con);
            sc.Parameters.Add("@GodinaId", SqlDbType.Int);
            sc.Parameters["@GodinaId"].Value = GodineForm.godinaId;
            sc.Parameters.Add("@ImePolja", SqlDbType.NChar);
            sc.Parameters["@ImePolja"].Value = imePoljaTextBox.Text;
            sc.ExecuteReader();
            con.Close();

            con.Open();
            SqlDataAdapter sdaPolja = new SqlDataAdapter("SELECT [ImePolja] FROM [Polje] WHERE [GodinaId]='" + GodineForm.godinaId + "'", con);

            List<object> list = new List<object>();
            DataTable t = new DataTable();
            DataSet s = new DataSet();
            sdaPolja.Fill(s);
            t = s.Tables[0];
            foreach (DataRow c in t.Rows)
            {
                list.Add(c["ImePolja"]);
            }

            poljaListBox.DataSource = list;

            con.Close();
        }

        private void poljaListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [PoljeId] FROM [Polje] WHERE [ImePolja]='" + poljaListBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataTableReader dtr = new DataTableReader(dt);
            while (dtr.Read())
            {
                poljeId = dtr.GetInt32(dtr.GetOrdinal("PoljeId"));
            }
            this.Close();
            DetaljiPoljaForm dp = new DetaljiPoljaForm();
            dp.Show();
        }
    }
}
