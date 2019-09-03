namespace HospitalCharges
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.daysSpentTextBox = new System.Windows.Forms.TextBox();
            this.medChargesTextBox = new System.Windows.Forms.TextBox();
            this.surgicalChargesTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.rehabChargesTextBox = new System.Windows.Forms.TextBox();
            this.totalChargesTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days spent in Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication Charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical Charges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physical Rehabilitation Charges";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 716);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Charges";
            // 
            // daysSpentTextBox
            // 
            this.daysSpentTextBox.Location = new System.Drawing.Point(522, 25);
            this.daysSpentTextBox.Name = "daysSpentTextBox";
            this.daysSpentTextBox.Size = new System.Drawing.Size(100, 31);
            this.daysSpentTextBox.TabIndex = 6;
            // 
            // medChargesTextBox
            // 
            this.medChargesTextBox.Location = new System.Drawing.Point(522, 150);
            this.medChargesTextBox.Name = "medChargesTextBox";
            this.medChargesTextBox.Size = new System.Drawing.Size(100, 31);
            this.medChargesTextBox.TabIndex = 7;
            // 
            // surgicalChargesTextBox
            // 
            this.surgicalChargesTextBox.Location = new System.Drawing.Point(522, 280);
            this.surgicalChargesTextBox.Name = "surgicalChargesTextBox";
            this.surgicalChargesTextBox.Size = new System.Drawing.Size(100, 31);
            this.surgicalChargesTextBox.TabIndex = 8;
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(522, 428);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 31);
            this.labFeesTextBox.TabIndex = 9;
            // 
            // rehabChargesTextBox
            // 
            this.rehabChargesTextBox.Location = new System.Drawing.Point(522, 576);
            this.rehabChargesTextBox.Name = "rehabChargesTextBox";
            this.rehabChargesTextBox.Size = new System.Drawing.Size(100, 31);
            this.rehabChargesTextBox.TabIndex = 10;
            // 
            // totalChargesTextBox
            // 
            this.totalChargesTextBox.Location = new System.Drawing.Point(522, 710);
            this.totalChargesTextBox.Name = "totalChargesTextBox";
            this.totalChargesTextBox.Size = new System.Drawing.Size(100, 31);
            this.totalChargesTextBox.TabIndex = 11;
            this.totalChargesTextBox.TextChanged += new System.EventHandler(this.totalChargesTextBox_TextChanged);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(59, 854);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(131, 83);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calculate Charges";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(299, 854);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 55);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(547, 854);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 55);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 984);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.totalChargesTextBox);
            this.Controls.Add(this.rehabChargesTextBox);
            this.Controls.Add(this.labFeesTextBox);
            this.Controls.Add(this.surgicalChargesTextBox);
            this.Controls.Add(this.medChargesTextBox);
            this.Controls.Add(this.daysSpentTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox daysSpentTextBox;
        private System.Windows.Forms.TextBox medChargesTextBox;
        private System.Windows.Forms.TextBox surgicalChargesTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox rehabChargesTextBox;
        private System.Windows.Forms.TextBox totalChargesTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

