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
    public partial class New_Password : Form
    {
             

        public New_Password()
        {
            InitializeComponent();
            ClearData();
        }    

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Return to Dashboard form         
            this.Close();
            
        }

        private void SavePasswordsButton_Click(object sender, EventArgs e)
        {
            string date, name, email, username, password;
            date = DateCreatedLabel.Text;
            name = NameTextBox.Text;
            email = EmailTextBox.Text;
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;


            // Insert New Password
            if (name != "" && email != "" && username != "" && password != "")
            {
                var conString = ConfigurationManager.ConnectionStrings["con"];
                string strConnString = conString.ConnectionString;
                SqlConnection con = new SqlConnection(strConnString);
                con.Open();
                string insertPassword = ("INSERT INTO Passwords (Date,Name,Email,Username,Password) values(@Date,@Name,@Email,@Username,@Password)");
                SqlCommand comm = new SqlCommand(insertPassword, con);                
                comm.Parameters.AddWithValue("@Date", DateCreatedLabel.Text);
                comm.Parameters.AddWithValue("@Name", NameTextBox.Text);
                comm.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                comm.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                comm.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved Succesfully", "PassPRO Password Manager",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                NameTextBox.BackColor = Color.White;
                EmailTextBox.BackColor = Color.White;
                UsernameTextBox.BackColor = Color.White;
                PasswordTextBox.BackColor = Color.White;

                ClearData();



            }
            else
            {
                //Error message if no information is provided for the updating the password
                MessageBox.Show("Please enter all information!", "PassPRO Password Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameTextBox.BackColor = Color.Red;
                EmailTextBox.BackColor = Color.Red;
                UsernameTextBox.BackColor = Color.Red;
                PasswordTextBox.BackColor = Color.Red;

            }               
                 
        }       
                
        private void New_Password_Load(object sender, EventArgs e)
        {
            // Set "Date Created" Label to automatically have todays date
            DateCreatedLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void ClearData()
        {
            //Clear All Data            
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";

        }
    }
}
