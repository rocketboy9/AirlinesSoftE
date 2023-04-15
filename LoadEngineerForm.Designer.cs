namespace Airlines
{
    partial class LoadEngineerForm
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
            labelFlightData = new Label();
            richTextBoxFlightData = new RichTextBox();
            textBoxOrigin = new TextBox();
            textBoxDestination = new TextBox();
            dateTimePickerFlightTakeoff = new DateTimePicker();
            buttonChangeFlight = new Button();
            labelChangeFlight = new Label();
            labelOrigin = new Label();
            labelDestination = new Label();
            labelTakeoffTime = new Label();
            SuspendLayout();
            // 
            // labelFlightData
            // 
            labelFlightData.AutoSize = true;
            labelFlightData.Location = new Point(587, 52);
            labelFlightData.Name = "labelFlightData";
            labelFlightData.Size = new Size(64, 15);
            labelFlightData.TabIndex = 0;
            labelFlightData.Text = "Flight Data";
            // 
            // richTextBoxFlightData
            // 
            richTextBoxFlightData.Enabled = false;
            richTextBoxFlightData.Location = new Point(510, 70);
            richTextBoxFlightData.Name = "richTextBoxFlightData";
            richTextBoxFlightData.Size = new Size(221, 311);
            richTextBoxFlightData.TabIndex = 1;
            richTextBoxFlightData.Text = "";
            // 
            // textBoxOrigin
            // 
            textBoxOrigin.Location = new Point(98, 146);
            textBoxOrigin.Name = "textBoxOrigin";
            textBoxOrigin.Size = new Size(100, 23);
            textBoxOrigin.TabIndex = 2;
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(261, 146);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(100, 23);
            textBoxDestination.TabIndex = 3;
            // 
            // dateTimePickerFlightTakeoff
            // 
            dateTimePickerFlightTakeoff.Location = new Point(131, 213);
            dateTimePickerFlightTakeoff.Name = "dateTimePickerFlightTakeoff";
            dateTimePickerFlightTakeoff.Size = new Size(200, 23);
            dateTimePickerFlightTakeoff.TabIndex = 4;
            // 
            // buttonChangeFlight
            // 
            buttonChangeFlight.Location = new Point(175, 288);
            buttonChangeFlight.Name = "buttonChangeFlight";
            buttonChangeFlight.Size = new Size(112, 23);
            buttonChangeFlight.TabIndex = 5;
            buttonChangeFlight.Text = "Change Flight";
            buttonChangeFlight.UseVisualStyleBackColor = true;
            buttonChangeFlight.Click += buttonChangeFlight_Click;
            // 
            // labelChangeFlight
            // 
            labelChangeFlight.AutoSize = true;
            labelChangeFlight.Location = new Point(87, 87);
            labelChangeFlight.Name = "labelChangeFlight";
            labelChangeFlight.Size = new Size(310, 15);
            labelChangeFlight.TabIndex = 6;
            labelChangeFlight.Text = "Select an origin, destination and time to change the flight";
            // 
            // labelOrigin
            // 
            labelOrigin.AutoSize = true;
            labelOrigin.Location = new Point(98, 128);
            labelOrigin.Name = "labelOrigin";
            labelOrigin.Size = new Size(40, 15);
            labelOrigin.TabIndex = 7;
            labelOrigin.Text = "Origin";
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Location = new Point(264, 128);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(67, 15);
            labelDestination.TabIndex = 8;
            labelDestination.Text = "Destination";
            // 
            // labelTakeoffTime
            // 
            labelTakeoffTime.AutoSize = true;
            labelTakeoffTime.Location = new Point(131, 195);
            labelTakeoffTime.Name = "labelTakeoffTime";
            labelTakeoffTime.Size = new Size(74, 15);
            labelTakeoffTime.TabIndex = 9;
            labelTakeoffTime.Text = "Takeoff Time";
            // 
            // LoadEngineerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTakeoffTime);
            Controls.Add(labelDestination);
            Controls.Add(labelOrigin);
            Controls.Add(labelChangeFlight);
            Controls.Add(buttonChangeFlight);
            Controls.Add(dateTimePickerFlightTakeoff);
            Controls.Add(textBoxDestination);
            Controls.Add(textBoxOrigin);
            Controls.Add(richTextBoxFlightData);
            Controls.Add(labelFlightData);
            Name = "LoadEngineerForm";
            Text = "LoadEngineerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFlightData;
        private RichTextBox richTextBoxFlightData;
        private TextBox textBoxOrigin;
        private TextBox textBoxDestination;
        private DateTimePicker dateTimePickerFlightTakeoff;
        private Button buttonChangeFlight;
        private Label labelChangeFlight;
        private Label labelOrigin;
        private Label labelDestination;
        private Label labelTakeoffTime;
    }
}