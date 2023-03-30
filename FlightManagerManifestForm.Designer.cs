namespace Airlines
{
    partial class FlightManagerManifestForm
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
            richTextBoxFlightManifest = new RichTextBox();
            labelFlightManifest = new Label();
            SuspendLayout();
            // 
            // richTextBoxFlightManifest
            // 
            richTextBoxFlightManifest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxFlightManifest.Location = new Point(12, 27);
            richTextBoxFlightManifest.Name = "richTextBoxFlightManifest";
            richTextBoxFlightManifest.Size = new Size(510, 580);
            richTextBoxFlightManifest.TabIndex = 0;
            richTextBoxFlightManifest.Text = "";
            // 
            // labelFlightManifest
            // 
            labelFlightManifest.AutoSize = true;
            labelFlightManifest.Location = new Point(16, 7);
            labelFlightManifest.Name = "labelFlightManifest";
            labelFlightManifest.Size = new Size(86, 15);
            labelFlightManifest.TabIndex = 1;
            labelFlightManifest.Text = "Flight Manifest";
            // 
            // FlightManagerManifestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 619);
            Controls.Add(labelFlightManifest);
            Controls.Add(richTextBoxFlightManifest);
            Name = "FlightManagerManifestForm";
            Text = "FlightManagerManifestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxFlightManifest;
        private Label labelFlightManifest;
    }
}