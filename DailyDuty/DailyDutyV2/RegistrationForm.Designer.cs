namespace DailyDutyV2
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.RegistrathionFormNAME = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Registrationbutton = new System.Windows.Forms.Button();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.authorizationLabel);
            this.panel1.Controls.Add(this.RegistrathionFormNAME);
            this.panel1.Controls.Add(this.Passwordlabel);
            this.panel1.Controls.Add(this.LoginLabel);
            this.panel1.Controls.Add(this.LastnameLabel);
            this.panel1.Controls.Add(this.Namelabel);
            this.panel1.Controls.Add(this.Registrationbutton);
            this.panel1.Controls.Add(this.PasswordField);
            this.panel1.Controls.Add(this.LoginField);
            this.panel1.Controls.Add(this.LastNameField);
            this.panel1.Controls.Add(this.NameField);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 594);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.AutoSize = true;
            this.authorizationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorizationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorizationLabel.Location = new System.Drawing.Point(556, 530);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(109, 19);
            this.authorizationLabel.TabIndex = 11;
            this.authorizationLabel.Text = "ავტორიზაცია";
            this.authorizationLabel.Click += new System.EventHandler(this.authorizationLabel_Click);
            // 
            // RegistrathionFormNAME
            // 
            this.RegistrathionFormNAME.AutoSize = true;
            this.RegistrathionFormNAME.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrathionFormNAME.Location = new System.Drawing.Point(391, 119);
            this.RegistrathionFormNAME.Name = "RegistrathionFormNAME";
            this.RegistrathionFormNAME.Size = new System.Drawing.Size(455, 32);
            this.RegistrathionFormNAME.TabIndex = 10;
            this.RegistrathionFormNAME.Text = "ახალი მომხმარებლის რეგისტრაცია";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordlabel.Location = new System.Drawing.Point(500, 397);
            this.Passwordlabel.MinimumSize = new System.Drawing.Size(234, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(234, 19);
            this.Passwordlabel.TabIndex = 9;
            this.Passwordlabel.Text = "პაროლი";
            this.Passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(499, 324);
            this.LoginLabel.MinimumSize = new System.Drawing.Size(234, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(234, 19);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "ლოგინი";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastnameLabel.Location = new System.Drawing.Point(500, 253);
            this.LastnameLabel.MinimumSize = new System.Drawing.Size(234, 0);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(234, 19);
            this.LastnameLabel.TabIndex = 7;
            this.LastnameLabel.Text = "გვარი";
            this.LastnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Namelabel
            // 
            this.Namelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Namelabel.Location = new System.Drawing.Point(500, 184);
            this.Namelabel.MinimumSize = new System.Drawing.Size(234, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(234, 19);
            this.Namelabel.TabIndex = 6;
            this.Namelabel.Text = "სახელი";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registrationbutton
            // 
            this.Registrationbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Registrationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.Registrationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrationbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registrationbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registrationbutton.Location = new System.Drawing.Point(521, 471);
            this.Registrationbutton.Name = "Registrationbutton";
            this.Registrationbutton.Size = new System.Drawing.Size(183, 56);
            this.Registrationbutton.TabIndex = 5;
            this.Registrationbutton.Text = "რეგისტრაცია";
            this.Registrationbutton.UseVisualStyleBackColor = false;
            this.Registrationbutton.Click += new System.EventHandler(this.Registrationbutton_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordField.Location = new System.Drawing.Point(499, 419);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(234, 29);
            this.PasswordField.TabIndex = 4;
            this.PasswordField.UseSystemPasswordChar = true;

            // 
            // LoginField
            // 
            this.LoginField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginField.Location = new System.Drawing.Point(499, 346);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(234, 29);
            this.LoginField.TabIndex = 3;
            // 
            // LastNameField
            // 
            this.LastNameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameField.Location = new System.Drawing.Point(500, 275);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(234, 29);
            this.LastNameField.TabIndex = 2;
            // 
            // NameField
            // 
            this.NameField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameField.Location = new System.Drawing.Point(499, 206);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(234, 29);
            this.NameField.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.CloseLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 100);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // CloseLabel
            // 
            this.CloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.Location = new System.Drawing.Point(1183, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(24, 28);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 594);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox PasswordField;
        private TextBox LoginField;
        private TextBox LastNameField;
        private TextBox NameField;
        private Panel panel2;
        private Button Registrationbutton;
        private Label Namelabel;
        private Label Passwordlabel;
        private Label LoginLabel;
        private Label LastnameLabel;
        private Label CloseLabel;
        private Label RegistrathionFormNAME;
        private Label authorizationLabel;
    }
}