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
    public partial class CreateAccount : Form
    {               

        public CreateAccount()
        {
            InitializeComponent();
        }      

        private void CreateAccountButton2_Click(object sender, EventArgs e)
        {

            string username2, password2;
            
            username2 = UsernameCATextBox.Text;
            password2 = PasswordMasked2TextBox.Text;

            // Insert New Password
            if (username2 != "" && password2 != "")
            {
                var conString = ConfigurationManager.ConnectionStrings["con"];
                string strConnString = conString.ConnectionString;
                SqlConnection con = new SqlConnection(strConnString);
                
                con.Open();
                string insertPassword = "INSERT INTO Login (Username,Password) values(@Username,@Password)";
                SqlCommand comm = new SqlCommand(insertPassword, con);               
                comm.Parameters.AddWithValue("@Username", UsernameCATextBox.Text);
                comm.Parameters.AddWithValue("@Password", PasswordMasked2TextBox.Text);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved Succesfully", "PassPRO Password Manager",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);                
                UsernameCATextBox.BackColor = Color.White;
                PasswordMasked2TextBox.BackColor = Color.White;

                ClearData();



            }
            else
            {
                //Error message if no information is provided for the updating the password
                MessageBox.Show("Please enter all information!", "PassPRO Password Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                
                UsernameCATextBox.BackColor = Color.Red;
                PasswordMasked2TextBox.BackColor = Color.Red;

            }
        }

        private void ClearData()
        {
            //Clear All Data      
            UsernameCATextBox.Text = "";
            PasswordMasked2TextBox.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Return to Dashboard form         
            this.Close();
        }
    }
}
