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
    public partial class Dashboard : Form
    {              

        public Dashboard()
        {
            InitializeComponent();

        }

        private void ShowPasswordsButton_Click(object sender, EventArgs e)
        {

            // Display Data in Data Grid View dgv1
            var conString = ConfigurationManager.ConnectionStrings["con"];
            string strConnString = conString.ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Passwords", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dgv1.DataSource = dtbl;
            con.Close();
            

        }

        private void NewPasswordButton_Click(object sender, EventArgs e)
        {
            // Open the New Password Form

            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "New_Password")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                New_Password form = new New_Password();
                Enabled = false;
                form.ShowDialog(this);
                Enabled = true;
                form.Dispose();


                
            }
            
            

          
            
            
        }

        private void UpdateDeletePasswordButton_Click(object sender, EventArgs e)
        {
            // Open the Update/Delete Password Form            
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "UpdateDelete")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                UpdateDelete form = new UpdateDelete();
                Enabled = false;
                form.ShowDialog(this);
                Enabled = true;
                form.Dispose();



            }


        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Open the Login Form            
            bool isopen = false;
            foreach (Form l in Application.OpenForms)
            {
                if (l.Text == "Login")
                {
                    isopen = true;
                    l.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                Login form = new Login();
                Enabled = false;
                form.ShowDialog(this);
                Enabled = true;
                form.Dispose();



            }
        }

        private void ExitButton3_Click(object sender, EventArgs e)
        {
            // Exit the Application to Windows
            System.Windows.Forms.Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            int columnPosition = 0;
            int rowPosition = 25;

            // run function to draw headers
            DrawHeader(new Font(this.Font, FontStyle.Bold), e.Graphics, ref columnPosition, ref rowPosition); // runs the DrawHeader function

            rowPosition += 35; // sets the distance below the header text and the next black line (ruler)

            // run function to draw each row
            DrawGridBody(e.Graphics, ref columnPosition, ref rowPosition);

            
        }

        // DrawHeader will draw the column title, move over, draw the next column title, move over, and continue.
        private int DrawHeader(Font boldFont, Graphics g, ref int columnPosition, ref int rowPosition)
        {
            foreach (DataGridViewColumn dc in dgv1.Columns)
            {

                //MessageBox.Show("dc = " + dc);

                g.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)rowPosition);
                columnPosition += dc.Width + 5; // adds to colPos. value the width value of the column + 5. 
            }

            return columnPosition;

            
        }

        /* DrawGridBody will loop though each row and draw it on the screen. It starts by drawing a solid line on the screen, 
         * then it moves down a row and draws the data from the first grid column, then it moves over, then draws the data from the next column,
         * moves over, draws the data from the next column, and continus this pattern. When the entire row is drawn it starts over and draws
         * a solid line then the row data, then the next solid line and then row data, etc.
        */
        private void DrawGridBody(Graphics g, ref int columnPosition, ref int rowPosition)
        {
            // loop through each row and draw the data to the graphics surface.
            foreach (DataRow dr in ((DataTable)dgv1.DataSource).Rows)
            {
                columnPosition = 0;

                // draw a line to separate the rows 
                g.DrawLine(Pens.Black, new Point(0, rowPosition), new Point(this.Width, rowPosition));

                // loop through each column in the row, and draw the individual data item
                foreach (DataGridViewColumn dc in dgv1.Columns)
                {
                    // draw string in the column
                    string text = dr[dc.DataPropertyName].ToString();
                    g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 10f); // the last number (10f) sets the space between the black line (ruler) and the text below it.

                    // go to the next column position
                    columnPosition += dc.Width + 5;
                }

                // go to the next row position
                rowPosition = rowPosition + 35; // this sets the space between the row text and the black line below it (ruler).

                
            }

            
        }

        private void PrintPasswordsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog(); // instantiate new print preview dialog
                printPreviewDialog1.Document = this.printDocument1;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK) // Show the print preview dialog, uses printPage event to draw preview screen
                {
                    printDocument1.Print();
                    
                }
            }
            catch (Exception exp)
            {
                System.Console.WriteLine(exp.Message.ToString());
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.printDocument1.DefaultPageSettings.Landscape = true;
        }

        private void GuidelinesButton_Click(object sender, EventArgs e)
        {
            // Open the Guidelines Form            
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Guidelines")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                Guidelines form = new Guidelines();
                Enabled = false;
                form.ShowDialog(this);
                Enabled = true;
                form.Dispose();



            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            // Open the About Form            
            bool isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "About")
                {
                    isopen = true;
                    f.BringToFront();
                    break;
                }
            }

            if (isopen == false)
            {
                About form = new About();
                Enabled = false;
                form.ShowDialog(this);
                Enabled = true;
                form.Dispose();



            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the Application to Windows
            System.Windows.Forms.Application.Exit();
        }
    }
}
