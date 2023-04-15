namespace Airlines
{
    partial class AccountHistoryForm
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
            labelFlightsTaken = new Label();
            labelFlightsBooked = new Label();
            labelFlightsCancelled = new Label();
            labelPointsUsed = new Label();
            labelPointsAvailable = new Label();
            textBoxPointsUsed = new TextBox();
            textBoxPointsAvailable = new TextBox();
            richTextBoxFlightsTaken = new RichTextBox();
            richTextBoxFlightsBooked = new RichTextBox();
            richTextBoxFlightsCancelled = new RichTextBox();
            SuspendLayout();
            // 
            // labelFlightsTaken
            // 
            labelFlightsTaken.AutoSize = true;
            labelFlightsTaken.Location = new Point(144, 102);
            labelFlightsTaken.Name = "labelFlightsTaken";
            labelFlightsTaken.Size = new Size(75, 15);
            labelFlightsTaken.TabIndex = 0;
            labelFlightsTaken.Text = "Flights Taken";
            // 
            // labelFlightsBooked
            // 
            labelFlightsBooked.AutoSize = true;
            labelFlightsBooked.Location = new Point(348, 102);
            labelFlightsBooked.Name = "labelFlightsBooked";
            labelFlightsBooked.Size = new Size(85, 15);
            labelFlightsBooked.TabIndex = 1;
            labelFlightsBooked.Text = "Flights Booked";
            // 
            // labelFlightsCancelled
            // 
            labelFlightsCancelled.AutoSize = true;
            labelFlightsCancelled.Location = new Point(551, 102);
            labelFlightsCancelled.Name = "labelFlightsCancelled";
            labelFlightsCancelled.Size = new Size(94, 15);
            labelFlightsCancelled.TabIndex = 2;
            labelFlightsCancelled.Text = "FlightsCancelled";
            // 
            // labelPointsUsed
            // 
            labelPointsUsed.AutoSize = true;
            labelPointsUsed.Location = new Point(191, 18);
            labelPointsUsed.Name = "labelPointsUsed";
            labelPointsUsed.Size = new Size(68, 15);
            labelPointsUsed.TabIndex = 3;
            labelPointsUsed.Text = "Points used";
            // 
            // labelPointsAvailable
            // 
            labelPointsAvailable.AutoSize = true;
            labelPointsAvailable.Location = new Point(171, 54);
            labelPointsAvailable.Name = "labelPointsAvailable";
            labelPointsAvailable.Size = new Size(88, 15);
            labelPointsAvailable.TabIndex = 4;
            labelPointsAvailable.Text = "PointsAvailable";
            // 
            // textBoxPointsUsed
            // 
            textBoxPointsUsed.Location = new Point(317, 10);
            textBoxPointsUsed.Name = "textBoxPointsUsed";
            textBoxPointsUsed.ReadOnly = true;
            textBoxPointsUsed.Size = new Size(100, 23);
            textBoxPointsUsed.TabIndex = 5;
            // 
            // textBoxPointsAvailable
            // 
            textBoxPointsAvailable.Location = new Point(317, 51);
            textBoxPointsAvailable.Name = "textBoxPointsAvailable";
            textBoxPointsAvailable.ReadOnly = true;
            textBoxPointsAvailable.Size = new Size(100, 23);
            textBoxPointsAvailable.TabIndex = 6;
            // 
            // richTextBoxFlightsTaken
            // 
            richTextBoxFlightsTaken.Location = new Point(103, 125);
            richTextBoxFlightsTaken.Name = "richTextBoxFlightsTaken";
            richTextBoxFlightsTaken.Size = new Size(156, 280);
            richTextBoxFlightsTaken.TabIndex = 7;
            richTextBoxFlightsTaken.Text = "";
            // 
            // richTextBoxFlightsBooked
            // 
            richTextBoxFlightsBooked.Location = new Point(317, 125);
            richTextBoxFlightsBooked.Name = "richTextBoxFlightsBooked";
            richTextBoxFlightsBooked.Size = new Size(156, 280);
            richTextBoxFlightsBooked.TabIndex = 8;
            richTextBoxFlightsBooked.Text = "";
            // 
            // richTextBoxFlightsCancelled
            // 
            richTextBoxFlightsCancelled.Location = new Point(540, 125);
            richTextBoxFlightsCancelled.Name = "richTextBoxFlightsCancelled";
            richTextBoxFlightsCancelled.Size = new Size(156, 280);
            richTextBoxFlightsCancelled.TabIndex = 9;
            richTextBoxFlightsCancelled.Text = "";
            // 
            // AccountHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxFlightsCancelled);
            Controls.Add(richTextBoxFlightsBooked);
            Controls.Add(richTextBoxFlightsTaken);
            Controls.Add(textBoxPointsAvailable);
            Controls.Add(textBoxPointsUsed);
            Controls.Add(labelPointsAvailable);
            Controls.Add(labelPointsUsed);
            Controls.Add(labelFlightsCancelled);
            Controls.Add(labelFlightsBooked);
            Controls.Add(labelFlightsTaken);
            Name = "AccountHistoryForm";
            Text = "AccountHistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFlightsTaken;
        private Label labelFlightsBooked;
        private Label labelFlightsCancelled;
        private Label labelPointsUsed;
        private Label labelPointsAvailable;
        private TextBox textBoxPointsUsed;
        private TextBox textBoxPointsAvailable;
        private RichTextBox richTextBoxFlightsTaken;
        private RichTextBox richTextBoxFlightsBooked;
        private RichTextBox richTextBoxFlightsCancelled;
    }
}