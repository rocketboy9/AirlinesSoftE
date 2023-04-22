namespace Airlines
{
    partial class MarketingManagerForm
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
            button757 = new Button();
            button767 = new Button();
            button777 = new Button();
            labelDesiredFlight = new Label();
            SuspendLayout();
            // 
            // button757
            // 
            button757.Location = new Point(182, 74);
            button757.Name = "button757";
            button757.Size = new Size(75, 23);
            button757.TabIndex = 0;
            button757.Text = "757";
            button757.UseVisualStyleBackColor = true;
            button757.Click += button757_Click;
            // 
            // button767
            // 
            button767.Location = new Point(182, 129);
            button767.Name = "button767";
            button767.Size = new Size(75, 23);
            button767.TabIndex = 1;
            button767.Text = "767";
            button767.UseVisualStyleBackColor = true;
            button767.Click += button767_Click;
            // 
            // button777
            // 
            button777.Location = new Point(182, 188);
            button777.Name = "button777";
            button777.Size = new Size(75, 23);
            button777.TabIndex = 2;
            button777.Text = "777";
            button777.UseVisualStyleBackColor = true;
            button777.Click += button777_Click;
            // 
            // labelDesiredFlight
            // 
            labelDesiredFlight.AutoSize = true;
            labelDesiredFlight.Location = new Point(140, 32);
            labelDesiredFlight.Name = "labelDesiredFlight";
            labelDesiredFlight.Size = new Size(155, 15);
            labelDesiredFlight.TabIndex = 3;
            labelDesiredFlight.Text = "Click desired plane for flight";
            // 
            // MarketingManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 302);
            Controls.Add(labelDesiredFlight);
            Controls.Add(button777);
            Controls.Add(button767);
            Controls.Add(button757);
            Name = "MarketingManagerForm";
            Text = "MarketingManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button757;
        private Button button767;
        private Button button777;
        private Label labelDesiredFlight;
    }
}