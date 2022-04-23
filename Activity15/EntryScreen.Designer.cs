namespace Activity15
{
    partial class EntryScreen
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
            this.birthMonthLabel = new System.Windows.Forms.Label();
            this.birthDayLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.dayListBox = new System.Windows.Forms.ListBox();
            this.signResultLabel = new System.Windows.Forms.Label();
            this.numPickLabel = new System.Windows.Forms.Label();
            this.numPickListBox = new System.Windows.Forms.ListBox();
            this.luckyButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // birthMonthLabel
            // 
            this.birthMonthLabel.AutoSize = true;
            this.birthMonthLabel.Location = new System.Drawing.Point(90, 30);
            this.birthMonthLabel.Name = "birthMonthLabel";
            this.birthMonthLabel.Size = new System.Drawing.Size(82, 19);
            this.birthMonthLabel.TabIndex = 0;
            this.birthMonthLabel.Text = "Birth Month";
            // 
            // birthDayLabel
            // 
            this.birthDayLabel.AutoSize = true;
            this.birthDayLabel.Location = new System.Drawing.Point(105, 70);
            this.birthDayLabel.Name = "birthDayLabel";
            this.birthDayLabel.Size = new System.Drawing.Size(67, 19);
            this.birthDayLabel.TabIndex = 1;
            this.birthDayLabel.Text = "Birth Day";
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Location = new System.Drawing.Point(61, 120);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(111, 19);
            this.signLabel.TabIndex = 2;
            this.signLabel.Text = "Astrological Sign";
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.ItemHeight = 19;
            this.monthListBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthListBox.Location = new System.Drawing.Point(178, 30);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(100, 23);
            this.monthListBox.TabIndex = 3;
            // 
            // dayListBox
            // 
            this.dayListBox.FormattingEnabled = true;
            this.dayListBox.ItemHeight = 19;
            this.dayListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayListBox.Location = new System.Drawing.Point(178, 70);
            this.dayListBox.Name = "dayListBox";
            this.dayListBox.Size = new System.Drawing.Size(100, 23);
            this.dayListBox.TabIndex = 4;
            // 
            // signResultLabel
            // 
            this.signResultLabel.AutoSize = true;
            this.signResultLabel.Location = new System.Drawing.Point(174, 120);
            this.signResultLabel.Name = "signResultLabel";
            this.signResultLabel.Size = new System.Drawing.Size(68, 19);
            this.signResultLabel.TabIndex = 5;
            this.signResultLabel.Text = "Your Sign";
            // 
            // numPickLabel
            // 
            this.numPickLabel.AutoSize = true;
            this.numPickLabel.Location = new System.Drawing.Point(71, 170);
            this.numPickLabel.Name = "numPickLabel";
            this.numPickLabel.Size = new System.Drawing.Size(101, 19);
            this.numPickLabel.TabIndex = 6;
            this.numPickLabel.Text = "Pick a Number";
            // 
            // numPickListBox
            // 
            this.numPickListBox.FormattingEnabled = true;
            this.numPickListBox.ItemHeight = 19;
            this.numPickListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.numPickListBox.Location = new System.Drawing.Point(178, 170);
            this.numPickListBox.Name = "numPickListBox";
            this.numPickListBox.Size = new System.Drawing.Size(100, 23);
            this.numPickListBox.TabIndex = 7;
            // 
            // luckyButton
            // 
            this.luckyButton.Location = new System.Drawing.Point(22, 245);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.Size = new System.Drawing.Size(150, 30);
            this.luckyButton.TabIndex = 8;
            this.luckyButton.Text = "Get Lucky Number";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(203, 245);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 30);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.luckyButton);
            this.Controls.Add(this.numPickListBox);
            this.Controls.Add(this.numPickLabel);
            this.Controls.Add(this.signResultLabel);
            this.Controls.Add(this.dayListBox);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.signLabel);
            this.Controls.Add(this.birthDayLabel);
            this.Controls.Add(this.birthMonthLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntryScreen";
            this.Text = "Lucky Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label birthMonthLabel;
        private System.Windows.Forms.Label birthDayLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.ListBox dayListBox;
        private System.Windows.Forms.Label signResultLabel;
        private System.Windows.Forms.Label numPickLabel;
        private System.Windows.Forms.ListBox numPickListBox;
        private System.Windows.Forms.Button luckyButton;
        private System.Windows.Forms.Button closeButton;
    }
}

