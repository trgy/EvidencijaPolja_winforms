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
    public partial class KreirajUserForm : Form
    {
        public KreirajUserForm()
        {
            InitializeComponent();
        }

        private void natragButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void noviUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
                
                con.Open();
                SqlCommand sc = new SqlCommand("INSERT INTO [User] ([User], [Password]) VALUES (@User, @Password)", con);
                sc.Parameters.Add("@User", SqlDbType.NVarChar);
                sc.Parameters["@User"].Value = noviUserTextBox.Text;
                sc.Parameters.Add("@Password", SqlDbType.NVarChar);
                sc.Parameters["@Password"].Value = noviPasswordTextBox.Text;
                sc.ExecuteReader();
                con.Close();
                MessageBox.Show("Korisničko ime dodano: " + noviUserTextBox.Text);
            }
            catch (SqlException)
            {
                MessageBox.Show("Unos neuspješan!");
            }
        }
    }
}
