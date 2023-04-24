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
            textBoxId = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonCreateNewAccount = new Button();
            labelAirlines = new Label();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Anchor = AnchorStyles.Top;
            textBoxId.Location = new Point(161, 80);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "Customer ID";
            textBoxId.Size = new Size(209, 23);
            textBoxId.TabIndex = 2;
            textBoxId.KeyDown += Login_KeyDown;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.Location = new Point(161, 128);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(209, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.KeyDown += Login_KeyDown;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top;
            buttonLogin.Location = new Point(204, 190);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(109, 23);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCreateNewAccount
            // 
            buttonCreateNewAccount.Anchor = AnchorStyles.Top;
            buttonCreateNewAccount.Location = new Point(178, 236);
            buttonCreateNewAccount.Name = "buttonCreateNewAccount";
            buttonCreateNewAccount.Size = new Size(166, 23);
            buttonCreateNewAccount.TabIndex = 4;
            buttonCreateNewAccount.Text = "Create new Account";
            buttonCreateNewAccount.UseVisualStyleBackColor = true;
            buttonCreateNewAccount.Click += buttonCreateNewAccount_Click;
            // 
            // labelAirlines
            // 
            labelAirlines.Anchor = AnchorStyles.Top;
            labelAirlines.AutoSize = true;
            labelAirlines.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelAirlines.Location = new Point(195, 25);
            labelAirlines.Name = "labelAirlines";
            labelAirlines.Size = new Size(137, 30);
            labelAirlines.TabIndex = 1;
            labelAirlines.Text = "3550 Airlines";
            labelAirlines.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 335);
            Controls.Add(labelAirlines);
            Controls.Add(buttonCreateNewAccount);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxId);
            Name = "LoginScreenForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonCreateNewAccount;
        private Label labelAirlines;
    }
}