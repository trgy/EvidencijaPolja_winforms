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
using System.Collections;

namespace EvidencijaPolja
{
    public partial class GodineForm : Form
    {
        public static int godinaId = 0;
        public GodineForm()
        {
            
            InitializeComponent();
            String user = "";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [User] FROM [User] WHERE [UserId]='"+ LoginForm.userId + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            DataTableReader dtr = new DataTableReader(dt);
            while (dtr.Read())
            {
                user = dtr.GetString(dtr.GetOrdinal("User"));
            }
            odjavaLabel.Text = user + " (odjava)";

            dtr.Close();

            SqlDataAdapter sdaGodine = new SqlDataAdapter("SELECT [Godina] FROM [Godina] WHERE [UserId]='" + LoginForm.userId + "'", con);

            List<object> list = new List<object>();
            DataTable t = new DataTable();
            DataSet s = new DataSet();
            sdaGodine.Fill(s);
            t = s.Tables[0];
            foreach (DataRow c in t.Rows)
            {
                list.Add(c["Godina"]);
            }
            
            godinaListBox.DataSource = list;
           
            con.Close();
        }

        private void odjavaLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
            LoginForm.userId = 0;
            godinaId = 0;
        }

        private void dodajGodinuButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            
            con.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO [Godina] ([UserId], [Godina]) VALUES (@UserId, @Godina)", con);
            sc.Parameters.Add("@UserId", SqlDbType.Int);
            sc.Parameters["@UserId"].Value = LoginForm.userId;
            sc.Parameters.Add("@Godina", SqlDbType.NChar);
            sc.Parameters["@Godina"].Value = dodajGodinuTextBox.Text;
            sc.ExecuteReader();
            con.Close();
            
            
            con.Open();
            
            SqlDataAdapter sdaGodine = new SqlDataAdapter("SELECT [Godina] FROM [Godina] WHERE [UserId]='" + LoginForm.userId + "'", con);
            List<object> list = new List<object>();
            DataTable t = new DataTable();
            DataSet s = new DataSet();
            sdaGodine.Fill(s);
            t = s.Tables[0];
            foreach (DataRow c in t.Rows)
            {
                list.Add(c["Godina"]);
            }

            godinaListBox.DataSource = list;
            con.Close();
        }

        private void godinaListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [GodinaId] FROM [Godina] WHERE [Godina]='" + godinaListBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataTableReader dtr = new DataTableReader(dt);
            while (dtr.Read())
            {
                godinaId = dtr.GetInt32(dtr.GetOrdinal("GodinaId"));
            }


            this.Close();
            PoljaForm pf = new PoljaForm();
            pf.Show();
        }

        
    }
}
