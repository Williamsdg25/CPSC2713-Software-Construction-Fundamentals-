namespace DormMealPlanCalculator
{
    partial class DormAndMealPlanForm
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
            this.selectDormLabel = new System.Windows.Forms.Label();
            this.selectMealLabel = new System.Windows.Forms.Label();
            this.dormListBox = new System.Windows.Forms.ListBox();
            this.mealsListBox = new System.Windows.Forms.ListBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectDormLabel
            // 
            this.selectDormLabel.AutoSize = true;
            this.selectDormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDormLabel.Location = new System.Drawing.Point(130, 122);
            this.selectDormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectDormLabel.Name = "selectDormLabel";
            this.selectDormLabel.Size = new System.Drawing.Size(328, 31);
            this.selectDormLabel.TabIndex = 0;
            this.selectDormLabel.Text = "Select a Dormitory Type";
            // 
            // selectMealLabel
            // 
            this.selectMealLabel.AutoSize = true;
            this.selectMealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMealLabel.Location = new System.Drawing.Point(816, 122);
            this.selectMealLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectMealLabel.Name = "selectMealLabel";
            this.selectMealLabel.Size = new System.Drawing.Size(263, 31);
            this.selectMealLabel.TabIndex = 1;
            this.selectMealLabel.Text = "Select a Meal Type";
            // 
            // dormListBox
            // 
            this.dormListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dormListBox.FormattingEnabled = true;
            this.dormListBox.ItemHeight = 31;
            this.dormListBox.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.dormListBox.Location = new System.Drawing.Point(137, 236);
            this.dormListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dormListBox.Name = "dormListBox";
            this.dormListBox.Size = new System.Drawing.Size(463, 438);
            this.dormListBox.TabIndex = 2;
            // 
            // mealsListBox
            // 
            this.mealsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealsListBox.FormattingEnabled = true;
            this.mealsListBox.ItemHeight = 31;
            this.mealsListBox.Items.AddRange(new object[] {
            "7 meals per week",
            "14 meals per week",
            "Unlimited meals"});
            this.mealsListBox.Location = new System.Drawing.Point(813, 236);
            this.mealsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mealsListBox.Name = "mealsListBox";
            this.mealsListBox.Size = new System.Drawing.Size(398, 438);
            this.mealsListBox.TabIndex = 3;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(261, 770);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(197, 63);
            this.totalButton.TabIndex = 4;
            this.totalButton.Text = "Show Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(906, 770);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(173, 61);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DormAndMealPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 945);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.mealsListBox);
            this.Controls.Add(this.dormListBox);
            this.Controls.Add(this.selectMealLabel);
            this.Controls.Add(this.selectDormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DormAndMealPlanForm";
            this.Text = "Dorm and Meal Plan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectDormLabel;
        private System.Windows.Forms.Label selectMealLabel;
        private System.Windows.Forms.ListBox dormListBox;
        private System.Windows.Forms.ListBox mealsListBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button exitButton;
    }
}

