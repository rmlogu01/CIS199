namespace Program2
{
    partial class program2
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
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterNameTB = new System.Windows.Forms.TextBox();
            this.classStandingGB = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.resultsTimeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.resultsDateLabel = new System.Windows.Forms.Label();
            this.classStandingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Location = new System.Drawing.Point(41, 35);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(106, 13);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Enter your last name:";
            // 
            // enterNameTB
            // 
            this.enterNameTB.Location = new System.Drawing.Point(163, 32);
            this.enterNameTB.Name = "enterNameTB";
            this.enterNameTB.Size = new System.Drawing.Size(100, 20);
            this.enterNameTB.TabIndex = 1;
            // 
            // classStandingGB
            // 
            this.classStandingGB.Controls.Add(this.seniorRadioButton);
            this.classStandingGB.Controls.Add(this.juniorRadioButton);
            this.classStandingGB.Controls.Add(this.sophomoreRadioButton);
            this.classStandingGB.Controls.Add(this.freshmanRadioButton);
            this.classStandingGB.Location = new System.Drawing.Point(54, 76);
            this.classStandingGB.Name = "classStandingGB";
            this.classStandingGB.Size = new System.Drawing.Size(200, 119);
            this.classStandingGB.TabIndex = 2;
            this.classStandingGB.TabStop = false;
            this.classStandingGB.Text = "Choose your class standing:";
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(62, 91);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(55, 17);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(62, 67);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(53, 17);
            this.juniorRadioButton.TabIndex = 2;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(62, 43);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreRadioButton.TabIndex = 1;
            this.sophomoreRadioButton.TabStop = true;
            this.sophomoreRadioButton.Text = "Sophomore";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(62, 19);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadioButton.TabIndex = 0;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(41, 207);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(92, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Registration Time:";
            // 
            // resultsTimeLabel
            // 
            this.resultsTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsTimeLabel.Location = new System.Drawing.Point(154, 204);
            this.resultsTimeLabel.Name = "resultsTimeLabel";
            this.resultsTimeLabel.Size = new System.Drawing.Size(109, 23);
            this.resultsTimeLabel.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(71, 295);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(146, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Registration Time";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(41, 249);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(92, 13);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Registration Date:";
            // 
            // resultsDateLabel
            // 
            this.resultsDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsDateLabel.Location = new System.Drawing.Point(154, 248);
            this.resultsDateLabel.Name = "resultsDateLabel";
            this.resultsDateLabel.Size = new System.Drawing.Size(109, 23);
            this.resultsDateLabel.TabIndex = 7;
            // 
            // program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 341);
            this.Controls.Add(this.resultsDateLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultsTimeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.classStandingGB);
            this.Controls.Add(this.enterNameTB);
            this.Controls.Add(this.enterNameLabel);
            this.Name = "program2";
            this.Text = "Program 2";
            this.classStandingGB.ResumeLayout(false);
            this.classStandingGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.TextBox enterNameTB;
        private System.Windows.Forms.GroupBox classStandingGB;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label resultsTimeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label resultsDateLabel;
    }
}

