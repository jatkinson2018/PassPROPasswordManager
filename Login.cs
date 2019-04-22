using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PasswordManager2019
{
    public partial class Login : Form
    {       

        public Login()
        {
            InitializeComponent();            

            PasswordMaskedTextBox.PasswordChar = '*';
            PasswordMaskedTextBox.MaxLength = 10;
            UsernameTextBox.MaxLength = 10;
        }             

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var conString = ConfigurationManager.ConnectionStrings["con"];
            string strConnString = conString.ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + UsernameTextBox.Text + "'and Password='" + PasswordMaskedTextBox.Text + "'", con);            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard openform = new Dashboard();
                openform.Show();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect", "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }       

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            // Open the Create Account Form
            this.Hide();
            CreateAccount form = new CreateAccount();
            form.ShowDialog();
            this.Show();
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            // Return to Dashboard form         
            this.Close();
        }
    }
}
