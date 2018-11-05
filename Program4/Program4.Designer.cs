namespace Program4
{
    partial class Program4
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
            this.originZipLabel = new System.Windows.Forms.Label();
            this.destZipLabel = new System.Windows.Forms.Label();
            this.packageInfoGB = new System.Windows.Forms.GroupBox();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.lengthTB = new System.Windows.Forms.TextBox();
            this.destTB = new System.Windows.Forms.TextBox();
            this.originTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.outputGB = new System.Windows.Forms.GroupBox();
            this.fromULButton = new System.Windows.Forms.Button();
            this.toULButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.packageInfoGB.SuspendLayout();
            this.outputGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // originZipLabel
            // 
            this.originZipLabel.AutoSize = true;
            this.originZipLabel.Location = new System.Drawing.Point(57, 51);
            this.originZipLabel.Name = "originZipLabel";
            this.originZipLabel.Size = new System.Drawing.Size(113, 25);
            this.originZipLabel.TabIndex = 0;
            this.originZipLabel.Text = "Origin ZIP:";
            // 
            // destZipLabel
            // 
            this.destZipLabel.AutoSize = true;
            this.destZipLabel.Location = new System.Drawing.Point(6, 90);
            this.destZipLabel.Name = "destZipLabel";
            this.destZipLabel.Size = new System.Drawing.Size(164, 25);
            this.destZipLabel.TabIndex = 1;
            this.destZipLabel.Text = "Destination ZIP:";
            // 
            // packageInfoGB
            // 
            this.packageInfoGB.Controls.Add(this.weightTB);
            this.packageInfoGB.Controls.Add(this.heightTB);
            this.packageInfoGB.Controls.Add(this.widthTB);
            this.packageInfoGB.Controls.Add(this.lengthTB);
            this.packageInfoGB.Controls.Add(this.destTB);
            this.packageInfoGB.Controls.Add(this.originTB);
            this.packageInfoGB.Controls.Add(this.addButton);
            this.packageInfoGB.Controls.Add(this.weightLabel);
            this.packageInfoGB.Controls.Add(this.heightLabel);
            this.packageInfoGB.Controls.Add(this.widthLabel);
            this.packageInfoGB.Controls.Add(this.lengthLabel);
            this.packageInfoGB.Controls.Add(this.destZipLabel);
            this.packageInfoGB.Controls.Add(this.originZipLabel);
            this.packageInfoGB.Location = new System.Drawing.Point(43, 32);
            this.packageInfoGB.Name = "packageInfoGB";
            this.packageInfoGB.Size = new System.Drawing.Size(336, 348);
            this.packageInfoGB.TabIndex = 2;
            this.packageInfoGB.TabStop = false;
            this.packageInfoGB.Text = "Enter Package Info";
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(177, 241);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(100, 31);
            this.weightTB.TabIndex = 12;
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(177, 202);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(100, 31);
            this.heightTB.TabIndex = 11;
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(177, 163);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(100, 31);
            this.widthTB.TabIndex = 10;
            // 
            // lengthTB
            // 
            this.lengthTB.Location = new System.Drawing.Point(177, 126);
            this.lengthTB.Name = "lengthTB";
            this.lengthTB.Size = new System.Drawing.Size(100, 31);
            this.lengthTB.TabIndex = 9;
            // 
            // destTB
            // 
            this.destTB.Location = new System.Drawing.Point(177, 88);
            this.destTB.Name = "destTB";
            this.destTB.Size = new System.Drawing.Size(100, 31);
            this.destTB.TabIndex = 8;
            // 
            // originTB
            // 
            this.originTB.Location = new System.Drawing.Point(177, 50);
            this.originTB.Name = "originTB";
            this.originTB.Size = new System.Drawing.Size(100, 31);
            this.originTB.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(114, 296);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 35);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(85, 245);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(85, 25);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(90, 206);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(80, 25);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(97, 166);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(73, 25);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(86, 128);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(84, 25);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length:";
            // 
            // outputGB
            // 
            this.outputGB.Controls.Add(this.fromULButton);
            this.outputGB.Controls.Add(this.toULButton);
            this.outputGB.Controls.Add(this.detailsButton);
            this.outputGB.Controls.Add(this.outputListBox);
            this.outputGB.Location = new System.Drawing.Point(409, 32);
            this.outputGB.Name = "outputGB";
            this.outputGB.Size = new System.Drawing.Size(431, 348);
            this.outputGB.TabIndex = 3;
            this.outputGB.TabStop = false;
            this.outputGB.Text = "Select a Package";
            // 
            // fromULButton
            // 
            this.fromULButton.Location = new System.Drawing.Point(276, 227);
            this.fromULButton.Name = "fromULButton";
            this.fromULButton.Size = new System.Drawing.Size(120, 76);
            this.fromULButton.TabIndex = 3;
            this.fromULButton.Text = "Send from U of L";
            this.fromULButton.UseVisualStyleBackColor = true;
            this.fromULButton.Click += new System.EventHandler(this.fromULButton_Click);
            // 
            // toULButton
            // 
            this.toULButton.Location = new System.Drawing.Point(282, 140);
            this.toULButton.Name = "toULButton";
            this.toULButton.Size = new System.Drawing.Size(104, 75);
            this.toULButton.TabIndex = 2;
            this.toULButton.Text = "Send to U of L";
            this.toULButton.UseVisualStyleBackColor = true;
            this.toULButton.Click += new System.EventHandler(this.toULButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.AutoSize = true;
            this.detailsButton.Location = new System.Drawing.Point(287, 68);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(94, 52);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 25;
            this.outputListBox.Location = new System.Drawing.Point(26, 40);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(210, 279);
            this.outputListBox.TabIndex = 0;
            // 
            // Program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 441);
            this.Controls.Add(this.outputGB);
            this.Controls.Add(this.packageInfoGB);
            this.Name = "Program4";
            this.Text = "Form1";
            this.packageInfoGB.ResumeLayout(false);
            this.packageInfoGB.PerformLayout();
            this.outputGB.ResumeLayout(false);
            this.outputGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label originZipLabel;
        private System.Windows.Forms.Label destZipLabel;
        private System.Windows.Forms.GroupBox packageInfoGB;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.TextBox lengthTB;
        private System.Windows.Forms.TextBox destTB;
        private System.Windows.Forms.TextBox originTB;
        private System.Windows.Forms.GroupBox outputGB;
        private System.Windows.Forms.Button fromULButton;
        private System.Windows.Forms.Button toULButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

