namespace Activity15
{
    partial class LuckyNumber
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
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.generatedLuckyNumber = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.AutoSize = true;
            this.luckyNumberLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyNumberLabel.Location = new System.Drawing.Point(11, 9);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(211, 27);
            this.luckyNumberLabel.TabIndex = 0;
            this.luckyNumberLabel.Text = "Your Lucky Number";
            // 
            // generatedLuckyNumber
            // 
            this.generatedLuckyNumber.AutoSize = true;
            this.generatedLuckyNumber.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedLuckyNumber.Location = new System.Drawing.Point(31, 62);
            this.generatedLuckyNumber.Name = "generatedLuckyNumber";
            this.generatedLuckyNumber.Size = new System.Drawing.Size(166, 67);
            this.generatedLuckyNumber.TabIndex = 1;
            this.generatedLuckyNumber.Text = "label1";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(71, 143);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LuckyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.generatedLuckyNumber);
            this.Controls.Add(this.luckyNumberLabel);
            this.Name = "LuckyNumber";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyNumberLabel;
        public System.Windows.Forms.Label generatedLuckyNumber;
        private System.Windows.Forms.Button closeButton;
    }
}