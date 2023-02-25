namespace Airlines
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentCustomer = new System.Windows.Forms.Label();
            this.buttonAccountHistory = new System.Windows.Forms.Button();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonFindOrCreateFlight = new System.Windows.Forms.Button();
            this.checkBoxRoundTrip = new System.Windows.Forms.CheckBox();
            this.dateTimePickerInitialFlight = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnFlight = new System.Windows.Forms.DateTimePicker();
            this.labelReturnFlight = new System.Windows.Forms.Label();
            this.labelFlightDate = new System.Windows.Forms.Label();
            this.richTextBoxFlightInformation = new System.Windows.Forms.RichTextBox();
            this.buttonAcceptFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelCurrentCustomer
            // 
            this.labelCurrentCustomer.AutoSize = true;
            this.labelCurrentCustomer.Location = new System.Drawing.Point(27, 19);
            this.labelCurrentCustomer.Name = "labelCurrentCustomer";
            this.labelCurrentCustomer.Size = new System.Drawing.Size(102, 15);
            this.labelCurrentCustomer.TabIndex = 0;
            this.labelCurrentCustomer.Text = "Current Customer";
            // 
            // buttonAccountHistory
            // 
            this.buttonAccountHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccountHistory.Location = new System.Drawing.Point(596, 15);
            this.buttonAccountHistory.Name = "buttonAccountHistory";
            this.buttonAccountHistory.Size = new System.Drawing.Size(126, 23);
            this.buttonAccountHistory.TabIndex = 1;
            this.buttonAccountHistory.Text = "Account History";
            this.buttonAccountHistory.UseVisualStyleBackColor = true;
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxOrigin.Location = new System.Drawing.Point(27, 152);
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.PlaceholderText = "Origin City";
            this.textBoxOrigin.Size = new System.Drawing.Size(209, 23);
            this.textBoxOrigin.TabIndex = 3;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDestination.Location = new System.Drawing.Point(27, 195);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.PlaceholderText = "Destination City";
            this.textBoxDestination.Size = new System.Drawing.Size(209, 23);
            this.textBoxDestination.TabIndex = 4;
            // 
            // buttonFindOrCreateFlight
            // 
            this.buttonFindOrCreateFlight.Location = new System.Drawing.Point(27, 321);
            this.buttonFindOrCreateFlight.Name = "buttonFindOrCreateFlight";
            this.buttonFindOrCreateFlight.Size = new System.Drawing.Size(120, 23);
            this.buttonFindOrCreateFlight.TabIndex = 5;
            this.buttonFindOrCreateFlight.Text = "Find or create flight";
            this.buttonFindOrCreateFlight.UseVisualStyleBackColor = true;
            this.buttonFindOrCreateFlight.Click += new System.EventHandler(this.buttonFindOrCreateFlight_Click);
            // 
            // checkBoxRoundTrip
            // 
            this.checkBoxRoundTrip.AutoSize = true;
            this.checkBoxRoundTrip.Location = new System.Drawing.Point(27, 235);
            this.checkBoxRoundTrip.Name = "checkBoxRoundTrip";
            this.checkBoxRoundTrip.Size = new System.Drawing.Size(83, 19);
            this.checkBoxRoundTrip.TabIndex = 6;
            this.checkBoxRoundTrip.Text = "Round Trip";
            this.checkBoxRoundTrip.UseVisualStyleBackColor = true;
            this.checkBoxRoundTrip.CheckedChanged += new System.EventHandler(this.checkBoxRoundTrip_CheckedChanged);
            // 
            // dateTimePickerInitialFlight
            // 
            this.dateTimePickerInitialFlight.Location = new System.Drawing.Point(27, 113);
            this.dateTimePickerInitialFlight.Name = "dateTimePickerInitialFlight";
            this.dateTimePickerInitialFlight.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerInitialFlight.TabIndex = 7;
            // 
            // dateTimePickerReturnFlight
            // 
            this.dateTimePickerReturnFlight.Location = new System.Drawing.Point(27, 281);
            this.dateTimePickerReturnFlight.Name = "dateTimePickerReturnFlight";
            this.dateTimePickerReturnFlight.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerReturnFlight.TabIndex = 8;
            this.dateTimePickerReturnFlight.Visible = false;
            // 
            // labelReturnFlight
            // 
            this.labelReturnFlight.AutoSize = true;
            this.labelReturnFlight.Location = new System.Drawing.Point(26, 260);
            this.labelReturnFlight.Name = "labelReturnFlight";
            this.labelReturnFlight.Size = new System.Drawing.Size(99, 15);
            this.labelReturnFlight.TabIndex = 9;
            this.labelReturnFlight.Text = "Return flight date";
            this.labelReturnFlight.Visible = false;
            // 
            // labelFlightDate
            // 
            this.labelFlightDate.AutoSize = true;
            this.labelFlightDate.Location = new System.Drawing.Point(26, 95);
            this.labelFlightDate.Name = "labelFlightDate";
            this.labelFlightDate.Size = new System.Drawing.Size(64, 15);
            this.labelFlightDate.TabIndex = 10;
            this.labelFlightDate.Text = "Flight Date";
            // 
            // richTextBoxFlightInformation
            // 
            this.richTextBoxFlightInformation.Location = new System.Drawing.Point(305, 113);
            this.richTextBoxFlightInformation.Name = "richTextBoxFlightInformation";
            this.richTextBoxFlightInformation.ReadOnly = true;
            this.richTextBoxFlightInformation.Size = new System.Drawing.Size(185, 156);
            this.richTextBoxFlightInformation.TabIndex = 11;
            this.richTextBoxFlightInformation.Text = "";
            this.richTextBoxFlightInformation.Visible = false;
            // 
            // buttonAcceptFlight
            // 
            this.buttonAcceptFlight.Location = new System.Drawing.Point(312, 275);
            this.buttonAcceptFlight.Name = "buttonAcceptFlight";
            this.buttonAcceptFlight.Size = new System.Drawing.Size(170, 23);
            this.buttonAcceptFlight.TabIndex = 12;
            this.buttonAcceptFlight.Text = "Pay and Resrve seat for flight";
            this.buttonAcceptFlight.UseVisualStyleBackColor = true;
            this.buttonAcceptFlight.Visible = false;
            this.buttonAcceptFlight.Click += new System.EventHandler(this.buttonAcceptFlight_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.buttonAcceptFlight);
            this.Controls.Add(this.richTextBoxFlightInformation);
            this.Controls.Add(this.labelFlightDate);
            this.Controls.Add(this.labelReturnFlight);
            this.Controls.Add(this.dateTimePickerReturnFlight);
            this.Controls.Add(this.dateTimePickerInitialFlight);
            this.Controls.Add(this.checkBoxRoundTrip);
            this.Controls.Add(this.buttonFindOrCreateFlight);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.textBoxOrigin);
            this.Controls.Add(this.buttonAccountHistory);
            this.Controls.Add(this.labelCurrentCustomer);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelCurrentCustomer;
        private Button buttonAccountHistory;
        private TextBox textBoxOrigin;
        private TextBox textBoxDestination;
        private Button buttonFindOrCreateFlight;
        private CheckBox checkBoxRoundTrip;
        private DateTimePicker dateTimePickerInitialFlight;
        private DateTimePicker dateTimePickerReturnFlight;
        private Label labelReturnFlight;
        private Label labelFlightDate;
        private RichTextBox richTextBoxFlightInformation;
        private Button buttonAcceptFlight;
    }
}