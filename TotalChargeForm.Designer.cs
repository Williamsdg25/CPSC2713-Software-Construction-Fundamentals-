namespace DormMealPlanCalculator
{
    partial class TotalChargeForm
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
            this.displayTotalLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTotalLabel
            // 
            this.displayTotalLabel.AutoSize = true;
            this.displayTotalLabel.Location = new System.Drawing.Point(283, 92);
            this.displayTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayTotalLabel.Name = "displayTotalLabel";
            this.displayTotalLabel.Size = new System.Drawing.Size(266, 31);
            this.displayTotalLabel.TabIndex = 0;
            this.displayTotalLabel.Text = "Total Amount is: $0";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(336, 198);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(177, 67);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TotalChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 404);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.displayTotalLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TotalChargeForm";
            this.Text = "Total Charges Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label displayTotalLabel;
    }
}