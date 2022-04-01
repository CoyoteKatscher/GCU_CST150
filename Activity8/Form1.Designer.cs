namespace Activity8
{
    partial class Activity8
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
            this.fatGramsConsumedLabel = new System.Windows.Forms.Label();
            this.carbGramsConsumedLabel = new System.Windows.Forms.Label();
            this.fatCaloriesLabel = new System.Windows.Forms.Label();
            this.carbCaloriesLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.fatConsumedTextBox = new System.Windows.Forms.TextBox();
            this.carbConsumedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fatGramsConsumedLabel
            // 
            this.fatGramsConsumedLabel.AutoSize = true;
            this.fatGramsConsumedLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatGramsConsumedLabel.Location = new System.Drawing.Point(125, 70);
            this.fatGramsConsumedLabel.Name = "fatGramsConsumedLabel";
            this.fatGramsConsumedLabel.Size = new System.Drawing.Size(234, 17);
            this.fatGramsConsumedLabel.TabIndex = 0;
            this.fatGramsConsumedLabel.Text = "Total fat consumed in a day (in grams)";
            // 
            // carbGramsConsumedLabel
            // 
            this.carbGramsConsumedLabel.AutoSize = true;
            this.carbGramsConsumedLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbGramsConsumedLabel.Location = new System.Drawing.Point(58, 100);
            this.carbGramsConsumedLabel.Name = "carbGramsConsumedLabel";
            this.carbGramsConsumedLabel.Size = new System.Drawing.Size(301, 17);
            this.carbGramsConsumedLabel.TabIndex = 1;
            this.carbGramsConsumedLabel.Text = "Total carbohydrates consumed in a day (in grams)";
            // 
            // fatCaloriesLabel
            // 
            this.fatCaloriesLabel.AutoSize = true;
            this.fatCaloriesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatCaloriesLabel.Location = new System.Drawing.Point(248, 200);
            this.fatCaloriesLabel.Name = "fatCaloriesLabel";
            this.fatCaloriesLabel.Size = new System.Drawing.Size(111, 17);
            this.fatCaloriesLabel.TabIndex = 2;
            this.fatCaloriesLabel.Text = "Calories from Fat";
            // 
            // carbCaloriesLabel
            // 
            this.carbCaloriesLabel.AutoSize = true;
            this.carbCaloriesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbCaloriesLabel.Location = new System.Drawing.Point(181, 230);
            this.carbCaloriesLabel.Name = "carbCaloriesLabel";
            this.carbCaloriesLabel.Size = new System.Drawing.Size(178, 17);
            this.carbCaloriesLabel.TabIndex = 3;
            this.carbCaloriesLabel.Text = "Calories from Carbohydrates";
            // 
            // calculateButton
            // 
            this.calculateButton.ForeColor = System.Drawing.Color.Gray;
            this.calculateButton.Location = new System.Drawing.Point(290, 140);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 40);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Calories";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.Gray;
            this.clearButton.Location = new System.Drawing.Point(284, 266);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.ForeColor = System.Drawing.Color.Gray;
            this.closeButton.Location = new System.Drawing.Point(365, 266);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 40);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fatConsumedTextBox
            // 
            this.fatConsumedTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatConsumedTextBox.Location = new System.Drawing.Point(365, 67);
            this.fatConsumedTextBox.Name = "fatConsumedTextBox";
            this.fatConsumedTextBox.Size = new System.Drawing.Size(100, 25);
            this.fatConsumedTextBox.TabIndex = 7;
            // 
            // carbConsumedTextBox
            // 
            this.carbConsumedTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbConsumedTextBox.Location = new System.Drawing.Point(365, 95);
            this.carbConsumedTextBox.Name = "carbConsumedTextBox";
            this.carbConsumedTextBox.Size = new System.Drawing.Size(100, 25);
            this.carbConsumedTextBox.TabIndex = 8;
            // 
            // Activity8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(709, 336);
            this.Controls.Add(this.carbConsumedTextBox);
            this.Controls.Add(this.fatConsumedTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.carbCaloriesLabel);
            this.Controls.Add(this.fatCaloriesLabel);
            this.Controls.Add(this.carbGramsConsumedLabel);
            this.Controls.Add(this.fatGramsConsumedLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Activity8";
            this.Text = "Activity 8 - Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatGramsConsumedLabel;
        private System.Windows.Forms.Label carbGramsConsumedLabel;
        private System.Windows.Forms.Label fatCaloriesLabel;
        private System.Windows.Forms.Label carbCaloriesLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox fatConsumedTextBox;
        private System.Windows.Forms.TextBox carbConsumedTextBox;
    }
}

