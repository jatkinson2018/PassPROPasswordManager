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
    public partial class UpdateDelete : Form
    {

        

        public UpdateDelete()
        {
            InitializeComponent();
            DisplayData();

            
        }      
     
               
        
        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            string email, password, IDU;

            IDU = IDUpTextBox.Text;            
            email = EmailTextBox.Text;            
            password = PasswordTextBox.Text;

            // Update Password
            if (IDU != "" && email != "" && password != "")
            {
                var conString = ConfigurationManager.ConnectionStrings["con"];
                string strConnString = conString.ConnectionString;
                SqlConnection con = new SqlConnection(strConnString);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Passwords SET Name=@Name, Email=@Email, Username=@Username, Password=@Password WHERE ID = @ID", con);                
                cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);                
                cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@ID", IDUpTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Updated Succesfully", "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDUpTextBox.BackColor = Color.White;                
                EmailTextBox.BackColor = Color.White;               
                PasswordTextBox.BackColor = Color.White;
                ClearData();
            }
            else
            {
                // Error message if no information is provided for the password setup
                MessageBox.Show("Please enter all information!", "PassPRO Password Manager",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDUpTextBox.BackColor = Color.Red;               
                EmailTextBox.BackColor = Color.Red;                
                PasswordTextBox.BackColor = Color.Red;

            }
            
        }

       
        private void DisplayData()
        {
            // Display Data in Data Grid View named dgv2
            var conString = ConfigurationManager.ConnectionStrings["con"];
            string strConnString = conString.ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Passwords", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv2.DataSource = dtbl;
            con.Close();

        }

        private void ClearData()
        {
            //Clear All Data
            IDUpTextBox.Text = "";
            IDDelTextBox.Text = "";           
            EmailTextBox.Text = "";           
            PasswordTextBox.Text = "";

        }

        private void DeletePasswordButton_Click(object sender, EventArgs e)
        {
            string IDD;
            IDD = IDDelTextBox.Text;

            //Delete Password
            if (IDD != "")
            {
                var conString = ConfigurationManager.ConnectionStrings["con"];
                string strConnString = conString.ConnectionString;
                SqlConnection con = new SqlConnection(strConnString);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Passwords WHERE ID ='" + IDDelTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                MessageBox.Show("Deleted Successfully", "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDDelTextBox.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Please enter an ID number!", "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDDelTextBox.BackColor = Color.Red;
            }
            
        }    

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Return to Dashboard form         
            this.Close();
        }
    }
}
