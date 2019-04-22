namespace PasswordManager2019
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton3 = new System.Windows.Forms.Button();
            this.GuidelinesButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.PrintPasswordsButton = new System.Windows.Forms.Button();
            this.UpdateDeletePasswordButton = new System.Windows.Forms.Button();
            this.NewPasswordButton = new System.Windows.Forms.Button();
            this.ShowPasswordsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordsDataSet = new PasswordManager2019.PasswordsDataSet();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.ExitButton3);
            this.panel1.Controls.Add(this.GuidelinesButton);
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.PrintPasswordsButton);
            this.panel1.Controls.Add(this.UpdateDeletePasswordButton);
            this.panel1.Controls.Add(this.NewPasswordButton);
            this.panel1.Controls.Add(this.ShowPasswordsButton);
            this.panel1.Location = new System.Drawing.Point(-2, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 1059);
            this.panel1.TabIndex = 14;
            // 
            // ExitButton3
            // 
            this.ExitButton3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitButton3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton3.ForeColor = System.Drawing.Color.White;
            this.ExitButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton3.Location = new System.Drawing.Point(23, 961);
            this.ExitButton3.Name = "ExitButton3";
            this.ExitButton3.Size = new System.Drawing.Size(254, 55);
            this.ExitButton3.TabIndex = 24;
            this.ExitButton3.Text = "Exit To Windows";
            this.ExitButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton3.UseVisualStyleBackColor = false;
            this.ExitButton3.Click += new System.EventHandler(this.ExitButton3_Click);
            // 
            // GuidelinesButton
            // 
            this.GuidelinesButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GuidelinesButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuidelinesButton.ForeColor = System.Drawing.Color.White;
            this.GuidelinesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuidelinesButton.Location = new System.Drawing.Point(20, 453);
            this.GuidelinesButton.Name = "GuidelinesButton";
            this.GuidelinesButton.Size = new System.Drawing.Size(254, 55);
            this.GuidelinesButton.TabIndex = 20;
            this.GuidelinesButton.Text = "Guidelines";
            this.GuidelinesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuidelinesButton.UseVisualStyleBackColor = false;
            this.GuidelinesButton.Click += new System.EventHandler(this.GuidelinesButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogoutButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.Location = new System.Drawing.Point(23, 900);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(254, 55);
            this.LogoutButton.TabIndex = 21;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AboutButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutButton.Location = new System.Drawing.Point(20, 392);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(254, 55);
            this.AboutButton.TabIndex = 19;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // PrintPasswordsButton
            // 
            this.PrintPasswordsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrintPasswordsButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPasswordsButton.ForeColor = System.Drawing.Color.White;
            this.PrintPasswordsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintPasswordsButton.Location = new System.Drawing.Point(20, 331);
            this.PrintPasswordsButton.Name = "PrintPasswordsButton";
            this.PrintPasswordsButton.Size = new System.Drawing.Size(254, 55);
            this.PrintPasswordsButton.TabIndex = 18;
            this.PrintPasswordsButton.Text = "Print Passwords";
            this.PrintPasswordsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintPasswordsButton.UseVisualStyleBackColor = false;
            this.PrintPasswordsButton.Click += new System.EventHandler(this.PrintPasswordsButton_Click);
            // 
            // UpdateDeletePasswordButton
            // 
            this.UpdateDeletePasswordButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateDeletePasswordButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDeletePasswordButton.ForeColor = System.Drawing.Color.White;
            this.UpdateDeletePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateDeletePasswordButton.Location = new System.Drawing.Point(20, 270);
            this.UpdateDeletePasswordButton.Name = "UpdateDeletePasswordButton";
            this.UpdateDeletePasswordButton.Size = new System.Drawing.Size(254, 55);
            this.UpdateDeletePasswordButton.TabIndex = 17;
            this.UpdateDeletePasswordButton.Text = "Update/Delete Password";
            this.UpdateDeletePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateDeletePasswordButton.UseVisualStyleBackColor = false;
            this.UpdateDeletePasswordButton.Click += new System.EventHandler(this.UpdateDeletePasswordButton_Click);
            // 
            // NewPasswordButton
            // 
            this.NewPasswordButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NewPasswordButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordButton.ForeColor = System.Drawing.Color.White;
            this.NewPasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewPasswordButton.Location = new System.Drawing.Point(20, 209);
            this.NewPasswordButton.Name = "NewPasswordButton";
            this.NewPasswordButton.Size = new System.Drawing.Size(254, 55);
            this.NewPasswordButton.TabIndex = 16;
            this.NewPasswordButton.Text = "Add New Password";
            this.NewPasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewPasswordButton.UseVisualStyleBackColor = false;
            this.NewPasswordButton.Click += new System.EventHandler(this.NewPasswordButton_Click);
            // 
            // ShowPasswordsButton
            // 
            this.ShowPasswordsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowPasswordsButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordsButton.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPasswordsButton.Location = new System.Drawing.Point(20, 148);
            this.ShowPasswordsButton.Name = "ShowPasswordsButton";
            this.ShowPasswordsButton.Size = new System.Drawing.Size(254, 55);
            this.ShowPasswordsButton.TabIndex = 15;
            this.ShowPasswordsButton.Text = "Show Passwords";
            this.ShowPasswordsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPasswordsButton.UseVisualStyleBackColor = false;
            this.ShowPasswordsButton.Click += new System.EventHandler(this.ShowPasswordsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(-2, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 898);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(55, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "PassPRO Password Manager - Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1927, 37);
            this.panel3.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.Location = new System.Drawing.Point(1885, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 36);
            this.ExitButton.TabIndex = 55;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PasswordManager2019.Properties.Resources.PassProLogo;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(18, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 145);
            this.panel5.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 60);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password\r\nManager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PasswordManager2019.Properties.Resources.PassProLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // passwordsDataSet
            // 
            this.passwordsDataSet.DataSetName = "PasswordsDataSet";
            this.passwordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv1.Location = new System.Drawing.Point(294, 41);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.RowTemplate.ReadOnly = true;
            this.dgv1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.Size = new System.Drawing.Size(1587, 1020);
            this.dgv1.TabIndex = 23;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Passwords";
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(1887, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 1163);
            this.panel6.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1370, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1920, 1063);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassPRO - Password Manager Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowPasswordsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NewPasswordButton;
        private System.Windows.Forms.Button UpdateDeletePasswordButton;
        private System.Windows.Forms.Button PrintPasswordsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button GuidelinesButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private PasswordsDataSet passwordsDataSet;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitButton3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitButton;
    }
}