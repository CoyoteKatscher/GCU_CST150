namespace Activity5
{
    partial class Activity5
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.firstWordLabel = new System.Windows.Forms.Label();
            this.lastWordLabel = new System.Windows.Forms.Label();
            this.longestWordLabel = new System.Windows.Forms.Label();
            this.mostVowelsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.firstWordTextBox = new System.Windows.Forms.TextBox();
            this.lastWordTextBox = new System.Windows.Forms.TextBox();
            this.longestWordTextBox = new System.Windows.Forms.TextBox();
            this.mostVowelsTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialogBox = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(138, 343);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(128, 44);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // firstWordLabel
            // 
            this.firstWordLabel.AutoSize = true;
            this.firstWordLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstWordLabel.ForeColor = System.Drawing.Color.White;
            this.firstWordLabel.Location = new System.Drawing.Point(110, 64);
            this.firstWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstWordLabel.Name = "firstWordLabel";
            this.firstWordLabel.Size = new System.Drawing.Size(156, 17);
            this.firstWordLabel.TabIndex = 1;
            this.firstWordLabel.Text = "First Word Alphabetically";
            // 
            // lastWordLabel
            // 
            this.lastWordLabel.AutoSize = true;
            this.lastWordLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastWordLabel.ForeColor = System.Drawing.Color.White;
            this.lastWordLabel.Location = new System.Drawing.Point(110, 137);
            this.lastWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastWordLabel.Name = "lastWordLabel";
            this.lastWordLabel.Size = new System.Drawing.Size(156, 17);
            this.lastWordLabel.TabIndex = 2;
            this.lastWordLabel.Text = "Last Word Alphabetically";
            // 
            // longestWordLabel
            // 
            this.longestWordLabel.AutoSize = true;
            this.longestWordLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestWordLabel.ForeColor = System.Drawing.Color.White;
            this.longestWordLabel.Location = new System.Drawing.Point(175, 211);
            this.longestWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longestWordLabel.Name = "longestWordLabel";
            this.longestWordLabel.Size = new System.Drawing.Size(91, 17);
            this.longestWordLabel.TabIndex = 3;
            this.longestWordLabel.Text = "Longest Word";
            // 
            // mostVowelsLabel
            // 
            this.mostVowelsLabel.AutoSize = true;
            this.mostVowelsLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostVowelsLabel.ForeColor = System.Drawing.Color.White;
            this.mostVowelsLabel.Location = new System.Drawing.Point(181, 284);
            this.mostVowelsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mostVowelsLabel.Name = "mostVowelsLabel";
            this.mostVowelsLabel.Size = new System.Drawing.Size(85, 17);
            this.mostVowelsLabel.TabIndex = 4;
            this.mostVowelsLabel.Text = "Most Vowels";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(449, 343);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(128, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // firstWordTextBox
            // 
            this.firstWordTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstWordTextBox.Location = new System.Drawing.Point(285, 61);
            this.firstWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstWordTextBox.Name = "firstWordTextBox";
            this.firstWordTextBox.Size = new System.Drawing.Size(292, 25);
            this.firstWordTextBox.TabIndex = 6;
            // 
            // lastWordTextBox
            // 
            this.lastWordTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastWordTextBox.Location = new System.Drawing.Point(285, 134);
            this.lastWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastWordTextBox.Name = "lastWordTextBox";
            this.lastWordTextBox.Size = new System.Drawing.Size(292, 25);
            this.lastWordTextBox.TabIndex = 7;
            // 
            // longestWordTextBox
            // 
            this.longestWordTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestWordTextBox.Location = new System.Drawing.Point(285, 208);
            this.longestWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.longestWordTextBox.Name = "longestWordTextBox";
            this.longestWordTextBox.Size = new System.Drawing.Size(292, 25);
            this.longestWordTextBox.TabIndex = 8;
            // 
            // mostVowelsTextBox
            // 
            this.mostVowelsTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostVowelsTextBox.Location = new System.Drawing.Point(285, 281);
            this.mostVowelsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mostVowelsTextBox.Name = "mostVowelsTextBox";
            this.mostVowelsTextBox.Size = new System.Drawing.Size(292, 25);
            this.mostVowelsTextBox.TabIndex = 9;
            // 
            // openFileDialogBox
            // 
            this.openFileDialogBox.FileName = "openFileDialogBox";
            // 
            // Activity5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(634, 436);
            this.Controls.Add(this.mostVowelsTextBox);
            this.Controls.Add(this.longestWordTextBox);
            this.Controls.Add(this.lastWordTextBox);
            this.Controls.Add(this.firstWordTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mostVowelsLabel);
            this.Controls.Add(this.longestWordLabel);
            this.Controls.Add(this.lastWordLabel);
            this.Controls.Add(this.firstWordLabel);
            this.Controls.Add(this.openFileButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Activity5";
            this.Text = "Activity 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label firstWordLabel;
        private System.Windows.Forms.Label lastWordLabel;
        private System.Windows.Forms.Label longestWordLabel;
        private System.Windows.Forms.Label mostVowelsLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox firstWordTextBox;
        private System.Windows.Forms.TextBox lastWordTextBox;
        private System.Windows.Forms.TextBox longestWordTextBox;
        private System.Windows.Forms.TextBox mostVowelsTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogBox;
    }
}

