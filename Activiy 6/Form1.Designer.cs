namespace Activiy_6
{
    partial class Activity6
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
            this.earthWeightLabel = new System.Windows.Forms.Label();
            this.marsWeightLabel = new System.Windows.Forms.Label();
            this.earthWeightEntryTextBox = new System.Windows.Forms.TextBox();
            this.marsWeightTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // earthWeightLabel
            // 
            this.earthWeightLabel.AutoSize = true;
            this.earthWeightLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earthWeightLabel.ForeColor = System.Drawing.Color.White;
            this.earthWeightLabel.Location = new System.Drawing.Point(52, 55);
            this.earthWeightLabel.Name = "earthWeightLabel";
            this.earthWeightLabel.Size = new System.Drawing.Size(167, 17);
            this.earthWeightLabel.TabIndex = 0;
            this.earthWeightLabel.Text = "Enter your weight on Earth";
            // 
            // marsWeightLabel
            // 
            this.marsWeightLabel.AutoSize = true;
            this.marsWeightLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsWeightLabel.ForeColor = System.Drawing.Color.White;
            this.marsWeightLabel.Location = new System.Drawing.Point(87, 100);
            this.marsWeightLabel.Name = "marsWeightLabel";
            this.marsWeightLabel.Size = new System.Drawing.Size(132, 17);
            this.marsWeightLabel.TabIndex = 1;
            this.marsWeightLabel.Text = "Your weight on Mars";
            // 
            // earthWeightEntryTextBox
            // 
            this.earthWeightEntryTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earthWeightEntryTextBox.Location = new System.Drawing.Point(234, 52);
            this.earthWeightEntryTextBox.Name = "earthWeightEntryTextBox";
            this.earthWeightEntryTextBox.Size = new System.Drawing.Size(191, 25);
            this.earthWeightEntryTextBox.TabIndex = 2;
            // 
            // marsWeightTextBox
            // 
            this.marsWeightTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsWeightTextBox.Location = new System.Drawing.Point(234, 97);
            this.marsWeightTextBox.Name = "marsWeightTextBox";
            this.marsWeightTextBox.Size = new System.Drawing.Size(191, 25);
            this.marsWeightTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(235, 149);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 30);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(435, 149);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 30);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(335, 149);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Activity6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(636, 245);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.marsWeightTextBox);
            this.Controls.Add(this.earthWeightEntryTextBox);
            this.Controls.Add(this.marsWeightLabel);
            this.Controls.Add(this.earthWeightLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Activity6";
            this.Text = "Activity 6 - Your Weight on Mars v2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earthWeightLabel;
        private System.Windows.Forms.Label marsWeightLabel;
        private System.Windows.Forms.TextBox earthWeightEntryTextBox;
        private System.Windows.Forms.TextBox marsWeightTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
    }
}

