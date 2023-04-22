namespace Airlines
{
    partial class AccountantForm
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
            richTextBoxAccountSummary = new RichTextBox();
            labelAccountant = new Label();
            textBoxTotalIncome = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBoxAccountSummary
            // 
            richTextBoxAccountSummary.Location = new Point(12, 28);
            richTextBoxAccountSummary.Name = "richTextBoxAccountSummary";
            richTextBoxAccountSummary.ReadOnly = true;
            richTextBoxAccountSummary.Size = new Size(401, 545);
            richTextBoxAccountSummary.TabIndex = 0;
            richTextBoxAccountSummary.Text = "";
            // 
            // labelAccountant
            // 
            labelAccountant.AutoSize = true;
            labelAccountant.Location = new Point(12, 10);
            labelAccountant.Name = "labelAccountant";
            labelAccountant.Size = new Size(122, 15);
            labelAccountant.TabIndex = 1;
            labelAccountant.Text = "Accounting summary";
            // 
            // textBoxTotalIncome
            // 
            textBoxTotalIncome.Enabled = false;
            textBoxTotalIncome.Location = new Point(116, 580);
            textBoxTotalIncome.Name = "textBoxTotalIncome";
            textBoxTotalIncome.Size = new Size(100, 23);
            textBoxTotalIncome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 583);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 3;
            label1.Text = "Total Income:";
            // 
            // AccountantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 615);
            Controls.Add(label1);
            Controls.Add(textBoxTotalIncome);
            Controls.Add(labelAccountant);
            Controls.Add(richTextBoxAccountSummary);
            Name = "AccountantForm";
            Text = "AccountantForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxAccountSummary;
        private Label labelAccountant;
        private TextBox textBoxTotalIncome;
        private Label label1;
    }
}