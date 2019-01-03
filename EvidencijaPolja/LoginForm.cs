using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace EvidencijaPolja
{

    public partial class LoginForm : Form
    {
        
        public static int userId = 0;
        public LoginForm()
        {
            InitializeComponent();
            
        }
        
        private void izlazButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
       
        private void kreirajNoviUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KreirajUserForm ku = new KreirajUserForm();
            ku.Show();
        }

        private void ulazButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Trgy\Documents\Visual Studio 2012\Projects\EvidencijaPolja\EvidencijaPolja\BazaPodataka.mdf;Integrated Security=True;");
           
            con.Open();
            SqlCommand sc = new SqlCommand("SELECT [UserId] FROM [User] WHERE [User] = @User AND [Password] = @Password", con);

            SqlParameter userParam = sc.Parameters.Add("@User", SqlDbType.NVarChar, 50 /* max length of field */ );
            userParam.Value = usernameTextBox.Text;
            SqlParameter passwordParam = sc.Parameters.Add("@Password", SqlDbType.NVarChar, 50 /* max length of field */ );
            passwordParam.Value = passwordTextBox.Text;
            SqlDataReader reader = sc.ExecuteReader();
            while (reader.Read())
            {
                userId = reader.GetInt32(reader.GetOrdinal("UserId"));
            }
            
            con.Close();

            if (userId != 0)
            {
                this.Hide();
                GodineForm gf = new GodineForm();
                gf.Show();
            }
            else
            {
                MessageBox.Show("Pogrešan username ili password");
            }
            con.Close();
         }

    }
}
