namespace DailyDutyV2
{
    partial class LoginForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.newUserRegistrationLabel = new System.Windows.Forms.Label();
            this.AuthorizationFormNAME = new System.Windows.Forms.Label();
            this.Authorization = new System.Windows.Forms.Button();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainPanel.Controls.Add(this.newUserRegistrationLabel);
            this.MainPanel.Controls.Add(this.AuthorizationFormNAME);
            this.MainPanel.Controls.Add(this.Authorization);
            this.MainPanel.Controls.Add(this.Passwordlabel);
            this.MainPanel.Controls.Add(this.LoginLabel);
            this.MainPanel.Controls.Add(this.PasswordField);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1298, 617);
            this.MainPanel.TabIndex = 0;
            // 
            // newUserRegistrationLabel
            // 
            this.newUserRegistrationLabel.AutoSize = true;
            this.newUserRegistrationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newUserRegistrationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUserRegistrationLabel.Location = new System.Drawing.Point(598, 475);
            this.newUserRegistrationLabel.Name = "newUserRegistrationLabel";
            this.newUserRegistrationLabel.Size = new System.Drawing.Size(107, 19);
            this.newUserRegistrationLabel.TabIndex = 13;
            this.newUserRegistrationLabel.Text = "რეგისტრაცია";
            this.newUserRegistrationLabel.Click += new System.EventHandler(this.newUserRegistrationLabel_Click);
            // 
            // AuthorizationFormNAME
            // 
            this.AuthorizationFormNAME.AutoSize = true;
            this.AuthorizationFormNAME.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorizationFormNAME.Location = new System.Drawing.Point(463, 165);
            this.AuthorizationFormNAME.Name = "AuthorizationFormNAME";
            this.AuthorizationFormNAME.Size = new System.Drawing.Size(380, 32);
            this.AuthorizationFormNAME.TabIndex = 12;
            this.AuthorizationFormNAME.Text = " მომხმარებლის ავტორიზაცია";
            // 
            // Authorization
            // 
            this.Authorization.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Authorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.Authorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Authorization.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Authorization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Authorization.Location = new System.Drawing.Point(559, 416);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(183, 56);
            this.Authorization.TabIndex = 11;
            this.Authorization.Text = "ავტორიზაცია";
            this.Authorization.UseVisualStyleBackColor = false;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordlabel.Location = new System.Drawing.Point(537, 287);
            this.Passwordlabel.MinimumSize = new System.Drawing.Size(234, 0);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(234, 19);
            this.Passwordlabel.TabIndex = 10;
            this.Passwordlabel.Text = "პაროლი";
            this.Passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(537, 233);
            this.LoginLabel.MinimumSize = new System.Drawing.Size(234, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(234, 19);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "ლოგინი";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordField.Location = new System.Drawing.Point(537, 309);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(234, 29);
            this.PasswordField.TabIndex = 5;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginField.Location = new System.Drawing.Point(537, 255);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(234, 29);
            this.LoginField.TabIndex = 4;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.TopPanel.Controls.Add(this.CloseLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1298, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // CloseLabel
            // 
            this.CloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.Location = new System.Drawing.Point(1262, 9);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(24, 28);
            this.CloseLabel.TabIndex = 13;
            this.CloseLabel.Text = "X";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 617);
            this.Controls.Add(this.MainPanel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel TopPanel;
        private TextBox LoginField;
        private TextBox PasswordField;
        private Label LoginLabel;
        private Label Passwordlabel;
        private Button Authorization;
        private Label AuthorizationFormNAME;
        private Label CloseLabel;
        private Label newUserRegistrationLabel;
    }
}