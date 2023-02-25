namespace Airlines
{
    partial class LoginScreenForm
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCreateNewAccount = new System.Windows.Forms.Button();
            this.labelAirlines = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxId.Location = new System.Drawing.Point(161, 80);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PlaceholderText = "Customer ID";
            this.textBoxId.Size = new System.Drawing.Size(209, 23);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.Location = new System.Drawing.Point(161, 128);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(209, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogin.Location = new System.Drawing.Point(204, 190);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(109, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCreateNewAccount
            // 
            this.buttonCreateNewAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCreateNewAccount.Location = new System.Drawing.Point(178, 236);
            this.buttonCreateNewAccount.Name = "buttonCreateNewAccount";
            this.buttonCreateNewAccount.Size = new System.Drawing.Size(166, 23);
            this.buttonCreateNewAccount.TabIndex = 4;
            this.buttonCreateNewAccount.Text = "Create new Account";
            this.buttonCreateNewAccount.UseVisualStyleBackColor = true;
            this.buttonCreateNewAccount.Click += new System.EventHandler(this.buttonCreateNewAccount_Click);
            // 
            // labelAirlines
            // 
            this.labelAirlines.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAirlines.AutoSize = true;
            this.labelAirlines.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAirlines.Location = new System.Drawing.Point(161, 21);
            this.labelAirlines.Name = "labelAirlines";
            this.labelAirlines.Size = new System.Drawing.Size(194, 30);
            this.labelAirlines.TabIndex = 1;
            this.labelAirlines.Text = "Something Airlines";
            this.labelAirlines.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 335);
            this.Controls.Add(this.labelAirlines);
            this.Controls.Add(this.buttonCreateNewAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxId);
            this.Name = "LoginScreen";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonCreateNewAccount;
        private Label labelAirlines;
    }
}