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
            label1 = new Label();
            labelCurrentCustomer = new Label();
            buttonAccountHistory = new Button();
            textBoxOrigin = new TextBox();
            textBoxDestination = new TextBox();
            buttonFindOrCreateFlight = new Button();
            checkBoxRoundTrip = new CheckBox();
            dateTimePickerInitialFlight = new DateTimePicker();
            dateTimePickerReturnFlight = new DateTimePicker();
            labelReturnFlight = new Label();
            labelFlightDate = new Label();
            richTextBoxFlightInformation = new RichTextBox();
            buttonAcceptFlight = new Button();
            buttonUsePoints = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // labelCurrentCustomer
            // 
            labelCurrentCustomer.AutoSize = true;
            labelCurrentCustomer.Location = new Point(27, 19);
            labelCurrentCustomer.Name = "labelCurrentCustomer";
            labelCurrentCustomer.Size = new Size(102, 15);
            labelCurrentCustomer.TabIndex = 0;
            labelCurrentCustomer.Text = "Current Customer";
            // 
            // buttonAccountHistory
            // 
            buttonAccountHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAccountHistory.Location = new Point(596, 15);
            buttonAccountHistory.Name = "buttonAccountHistory";
            buttonAccountHistory.Size = new Size(126, 23);
            buttonAccountHistory.TabIndex = 1;
            buttonAccountHistory.Text = "Account History";
            buttonAccountHistory.UseVisualStyleBackColor = true;
            buttonAccountHistory.Click += buttonAccountHistory_Click;
            // 
            // textBoxOrigin
            // 
            textBoxOrigin.Anchor = AnchorStyles.Top;
            textBoxOrigin.Location = new Point(27, 152);
            textBoxOrigin.Name = "textBoxOrigin";
            textBoxOrigin.PlaceholderText = "Origin City";
            textBoxOrigin.Size = new Size(209, 23);
            textBoxOrigin.TabIndex = 3;
            // 
            // textBoxDestination
            // 
            textBoxDestination.Anchor = AnchorStyles.Top;
            textBoxDestination.Location = new Point(27, 195);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.PlaceholderText = "Destination City";
            textBoxDestination.Size = new Size(209, 23);
            textBoxDestination.TabIndex = 4;
            // 
            // buttonFindOrCreateFlight
            // 
            buttonFindOrCreateFlight.Location = new Point(27, 321);
            buttonFindOrCreateFlight.Name = "buttonFindOrCreateFlight";
            buttonFindOrCreateFlight.Size = new Size(120, 23);
            buttonFindOrCreateFlight.TabIndex = 5;
            buttonFindOrCreateFlight.Text = "Find or create flight";
            buttonFindOrCreateFlight.UseVisualStyleBackColor = true;
            buttonFindOrCreateFlight.Click += buttonFindOrCreateFlight_Click;
            // 
            // checkBoxRoundTrip
            // 
            checkBoxRoundTrip.AutoSize = true;
            checkBoxRoundTrip.Location = new Point(27, 235);
            checkBoxRoundTrip.Name = "checkBoxRoundTrip";
            checkBoxRoundTrip.Size = new Size(83, 19);
            checkBoxRoundTrip.TabIndex = 6;
            checkBoxRoundTrip.Text = "Round Trip";
            checkBoxRoundTrip.UseVisualStyleBackColor = true;
            checkBoxRoundTrip.CheckedChanged += checkBoxRoundTrip_CheckedChanged;
            // 
            // dateTimePickerInitialFlight
            // 
            dateTimePickerInitialFlight.Location = new Point(27, 113);
            dateTimePickerInitialFlight.Name = "dateTimePickerInitialFlight";
            dateTimePickerInitialFlight.Size = new Size(200, 23);
            dateTimePickerInitialFlight.TabIndex = 7;
            // 
            // dateTimePickerReturnFlight
            // 
            dateTimePickerReturnFlight.Location = new Point(27, 281);
            dateTimePickerReturnFlight.Name = "dateTimePickerReturnFlight";
            dateTimePickerReturnFlight.Size = new Size(200, 23);
            dateTimePickerReturnFlight.TabIndex = 8;
            dateTimePickerReturnFlight.Visible = false;
            // 
            // labelReturnFlight
            // 
            labelReturnFlight.AutoSize = true;
            labelReturnFlight.Location = new Point(26, 260);
            labelReturnFlight.Name = "labelReturnFlight";
            labelReturnFlight.Size = new Size(99, 15);
            labelReturnFlight.TabIndex = 9;
            labelReturnFlight.Text = "Return flight date";
            labelReturnFlight.Visible = false;
            // 
            // labelFlightDate
            // 
            labelFlightDate.AutoSize = true;
            labelFlightDate.Location = new Point(26, 95);
            labelFlightDate.Name = "labelFlightDate";
            labelFlightDate.Size = new Size(64, 15);
            labelFlightDate.TabIndex = 10;
            labelFlightDate.Text = "Flight Date";
            // 
            // richTextBoxFlightInformation
            // 
            richTextBoxFlightInformation.Location = new Point(305, 113);
            richTextBoxFlightInformation.Name = "richTextBoxFlightInformation";
            richTextBoxFlightInformation.ReadOnly = true;
            richTextBoxFlightInformation.Size = new Size(185, 156);
            richTextBoxFlightInformation.TabIndex = 11;
            richTextBoxFlightInformation.Text = "";
            richTextBoxFlightInformation.Visible = false;
            // 
            // buttonAcceptFlight
            // 
            buttonAcceptFlight.Location = new Point(312, 275);
            buttonAcceptFlight.Name = "buttonAcceptFlight";
            buttonAcceptFlight.Size = new Size(170, 23);
            buttonAcceptFlight.TabIndex = 12;
            buttonAcceptFlight.Text = "Pay and Resrve seat for flight";
            buttonAcceptFlight.UseVisualStyleBackColor = true;
            buttonAcceptFlight.Visible = false;
            buttonAcceptFlight.Click += buttonAcceptFlight_Click;
            // 
            // buttonUsePoints
            // 
            buttonUsePoints.Location = new Point(340, 304);
            buttonUsePoints.Name = "buttonUsePoints";
            buttonUsePoints.Size = new Size(108, 23);
            buttonUsePoints.TabIndex = 13;
            buttonUsePoints.Text = "Use Points";
            buttonUsePoints.UseVisualStyleBackColor = true;
            buttonUsePoints.Visible = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(734, 441);
            Controls.Add(buttonUsePoints);
            Controls.Add(buttonAcceptFlight);
            Controls.Add(richTextBoxFlightInformation);
            Controls.Add(labelFlightDate);
            Controls.Add(labelReturnFlight);
            Controls.Add(dateTimePickerReturnFlight);
            Controls.Add(dateTimePickerInitialFlight);
            Controls.Add(checkBoxRoundTrip);
            Controls.Add(buttonFindOrCreateFlight);
            Controls.Add(textBoxDestination);
            Controls.Add(textBoxOrigin);
            Controls.Add(buttonAccountHistory);
            Controls.Add(labelCurrentCustomer);
            Name = "MainForm";
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonUsePoints;
    }
}