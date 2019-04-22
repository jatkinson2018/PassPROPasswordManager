using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager2019
{
    public partial class ServerConfiguration : Form
    {        
        

        public ServerConfiguration()
        {
            InitializeComponent();
        }

        private void ExitButton4_Click(object sender, EventArgs e)
        {
            // Exit the Application to Windows
            System.Windows.Forms.Application.Exit();
        }
        

        private void ServerConfiguration_Load(object sender, EventArgs e)
        {
            ServerComboBox.Items.Add(".");
            ServerComboBox.Items.Add("(local)");
            ServerComboBox.Items.Add(@".\SQLEXPRESS");
            ServerComboBox.Items.Add(string.Format(@"{0}", Environment.MachineName));
            ServerComboBox.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            ServerComboBox.SelectedIndex = 4;
        }

        private void ConnectServerButton_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", ServerComboBox.Text, DatabaseTextBox.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Connected Successfully!", "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveServerButton_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", ServerComboBox.Text, DatabaseTextBox.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("con", connectionString);
                    MessageBox.Show("Your connecting string has been saved successfully!", "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "PassPRO Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
