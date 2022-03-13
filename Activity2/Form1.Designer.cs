namespace Activity2
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
            this.weightEntryTextBox = new System.Windows.Forms.TextBox();
            this.marsWeightTextBox = new System.Windows.Forms.TextBox();
            this.weightEntryText = new System.Windows.Forms.Label();
            this.marsWeightText = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightEntryTextBox
            // 
            this.weightEntryTextBox.Location = new System.Drawing.Point(171, 39);
            this.weightEntryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightEntryTextBox.Name = "weightEntryTextBox";
            this.weightEntryTextBox.Size = new System.Drawing.Size(76, 20);
            this.weightEntryTextBox.TabIndex = 0;
            // 
            // marsWeightTextBox
            // 
            this.marsWeightTextBox.Location = new System.Drawing.Point(171, 83);
            this.marsWeightTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marsWeightTextBox.Name = "marsWeightTextBox";
            this.marsWeightTextBox.Size = new System.Drawing.Size(76, 20);
            this.marsWeightTextBox.TabIndex = 1;
            // 
            // weightEntryText
            // 
            this.weightEntryText.AutoSize = true;
            this.weightEntryText.Location = new System.Drawing.Point(28, 39);
            this.weightEntryText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightEntryText.Name = "weightEntryText";
            this.weightEntryText.Size = new System.Drawing.Size(132, 13);
            this.weightEntryText.TabIndex = 2;
            this.weightEntryText.Text = "Enter your weight on Earth";
            // 
            // marsWeightText
            // 
            this.marsWeightText.AutoSize = true;
            this.marsWeightText.Location = new System.Drawing.Point(52, 83);
            this.marsWeightText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.marsWeightText.Name = "marsWeightText";
            this.marsWeightText.Size = new System.Drawing.Size(104, 13);
            this.marsWeightText.TabIndex = 3;
            this.marsWeightText.Text = "Your weight on Mars";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(171, 120);
            this.convertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(56, 19);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(259, 120);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(56, 19);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Activity 2\r\nBrian Potter\r\n03/13/2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.marsWeightText);
            this.Controls.Add(this.weightEntryText);
            this.Controls.Add(this.marsWeightTextBox);
            this.Controls.Add(this.weightEntryTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Activity 2 - Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weightEntryTextBox;
        private System.Windows.Forms.TextBox marsWeightTextBox;
        private System.Windows.Forms.Label weightEntryText;
        private System.Windows.Forms.Label marsWeightText;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

