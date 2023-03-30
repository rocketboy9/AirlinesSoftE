namespace Airlines
{
    partial class FlightManagerForm
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
            listBoxFlights = new ListBox();
            SuspendLayout();
            // 
            // listBoxFlights
            // 
            listBoxFlights.DisplayMember = "Lane";
            listBoxFlights.FormattingEnabled = true;
            listBoxFlights.ItemHeight = 15;
            listBoxFlights.Location = new Point(145, 43);
            listBoxFlights.Name = "listBoxFlights";
            listBoxFlights.Size = new Size(453, 289);
            listBoxFlights.TabIndex = 0;
            listBoxFlights.ValueMember = "FlightID";
            listBoxFlights.SelectedValueChanged += listBoxFlights_SelectedValueChanged;
            // 
            // FlightManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxFlights);
            Name = "FlightManagerForm";
            Text = "FlightManagerForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxFlights;
    }
}