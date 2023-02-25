namespace Airlines
{
    partial class NewAccountForm
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
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxCreditCard = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(476, 460);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateAccount.TabIndex = 0;
            this.buttonCreateAccount.Text = "Create";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFirstName.Location = new System.Drawing.Point(193, 88);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PlaceholderText = "First Name";
            this.textBoxFirstName.Size = new System.Drawing.Size(201, 23);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateAccount.Location = new System.Drawing.Point(217, 21);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(156, 30);
            this.labelCreateAccount.TabIndex = 9;
            this.labelCreateAccount.Text = "Create Account";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLastName.Location = new System.Drawing.Point(193, 138);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PlaceholderText = "LastName";
            this.textBoxLastName.Size = new System.Drawing.Size(201, 23);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAddress.Location = new System.Drawing.Point(193, 233);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PlaceholderText = "Address";
            this.textBoxAddress.Size = new System.Drawing.Size(201, 23);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(193, 282);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.PlaceholderText = "Phone Number";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(201, 23);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAge.Location = new System.Drawing.Point(193, 334);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.PlaceholderText = "Age";
            this.textBoxAge.Size = new System.Drawing.Size(201, 23);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.Location = new System.Drawing.Point(193, 186);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.Size = new System.Drawing.Size(201, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(386, 460);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxCreditCard
            // 
            this.textBoxCreditCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCreditCard.Location = new System.Drawing.Point(193, 388);
            this.textBoxCreditCard.Name = "textBoxCreditCard";
            this.textBoxCreditCard.PlaceholderText = "Credit Card Number";
            this.textBoxCreditCard.Size = new System.Drawing.Size(201, 23);
            this.textBoxCreditCard.TabIndex = 7;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(12, 459);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(133, 21);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "ID For Logging in:";
            this.labelID.Visible = false;
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 495);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxCreditCard);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonCreateAccount);
            this.Name = "NewAccountForm";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonCreateAccount;
        private TextBox textBoxFirstName;
        private Label labelCreateAccount;
        private TextBox textBoxLastName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAge;
        private TextBox textBoxPassword;
        private Button buttonClose;
        private TextBox textBoxCreditCard;
        private Label labelID;
    }
}