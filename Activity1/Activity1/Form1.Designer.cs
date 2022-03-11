namespace Activity1
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
            this.buttonHello = new System.Windows.Forms.Button();
            this.helloClassButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity 1\r\nBrian Potter\r\n03/10/2022";
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(86, 37);
            this.buttonHello.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(74, 19);
            this.buttonHello.TabIndex = 1;
            this.buttonHello.Text = "Hello";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // helloClassButton
            // 
            this.helloClassButton.Location = new System.Drawing.Point(86, 74);
            this.helloClassButton.Name = "helloClassButton";
            this.helloClassButton.Size = new System.Drawing.Size(75, 23);
            this.helloClassButton.TabIndex = 2;
            this.helloClassButton.Text = "Hello Class";
            this.helloClassButton.UseVisualStyleBackColor = true;
            this.helloClassButton.Click += new System.EventHandler(this.helloClassButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(86, 120);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(100, 20);
            this.messageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.helloClassButton);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "CST150 - Activity 1 - Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button helloClassButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label2;
    }
}

