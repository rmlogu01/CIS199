namespace Program1
{
    partial class Program1
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
            this.sqrFeetLabel = new System.Windows.Forms.Label();
            this.numCoatsLabel = new System.Windows.Forms.Label();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.sqrFeetTB = new System.Windows.Forms.TextBox();
            this.numCoatsTB = new System.Windows.Forms.TextBox();
            this.paintPriceTB = new System.Windows.Forms.TextBox();
            this.feetPaintedLabel = new System.Windows.Forms.Label();
            this.gallonsNeededLabel = new System.Windows.Forms.Label();
            this.hoursLaborLabel = new System.Windows.Forms.Label();
            this.costPaintLabel = new System.Windows.Forms.Label();
            this.costLaborLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.sqrFeetCalc = new System.Windows.Forms.Label();
            this.numGallonCalc = new System.Windows.Forms.Label();
            this.hoursLaborCalc = new System.Windows.Forms.Label();
            this.costPaintCalc = new System.Windows.Forms.Label();
            this.costLaborCalc = new System.Windows.Forms.Label();
            this.totalCostCalc = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqrFeetLabel
            // 
            this.sqrFeetLabel.AutoSize = true;
            this.sqrFeetLabel.Location = new System.Drawing.Point(88, 39);
            this.sqrFeetLabel.Name = "sqrFeetLabel";
            this.sqrFeetLabel.Size = new System.Drawing.Size(98, 13);
            this.sqrFeetLabel.TabIndex = 0;
            this.sqrFeetLabel.Text = "Square feet of wall:";
            // 
            // numCoatsLabel
            // 
            this.numCoatsLabel.AutoSize = true;
            this.numCoatsLabel.Location = new System.Drawing.Point(60, 68);
            this.numCoatsLabel.Name = "numCoatsLabel";
            this.numCoatsLabel.Size = new System.Drawing.Size(126, 13);
            this.numCoatsLabel.TabIndex = 1;
            this.numCoatsLabel.Text = "Number of coats of paint:";
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.AutoSize = true;
            this.paintPriceLabel.Location = new System.Drawing.Point(65, 97);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(121, 13);
            this.paintPriceLabel.TabIndex = 2;
            this.paintPriceLabel.Text = "Price of paint per gallon:";
            // 
            // sqrFeetTB
            // 
            this.sqrFeetTB.Location = new System.Drawing.Point(192, 36);
            this.sqrFeetTB.Name = "sqrFeetTB";
            this.sqrFeetTB.Size = new System.Drawing.Size(100, 20);
            this.sqrFeetTB.TabIndex = 3;
            // 
            // numCoatsTB
            // 
            this.numCoatsTB.Location = new System.Drawing.Point(192, 65);
            this.numCoatsTB.Name = "numCoatsTB";
            this.numCoatsTB.Size = new System.Drawing.Size(100, 20);
            this.numCoatsTB.TabIndex = 4;
            // 
            // paintPriceTB
            // 
            this.paintPriceTB.Location = new System.Drawing.Point(192, 94);
            this.paintPriceTB.Name = "paintPriceTB";
            this.paintPriceTB.Size = new System.Drawing.Size(100, 20);
            this.paintPriceTB.TabIndex = 5;
            // 
            // feetPaintedLabel
            // 
            this.feetPaintedLabel.AutoSize = true;
            this.feetPaintedLabel.Location = new System.Drawing.Point(31, 128);
            this.feetPaintedLabel.Name = "feetPaintedLabel";
            this.feetPaintedLabel.Size = new System.Drawing.Size(155, 13);
            this.feetPaintedLabel.TabIndex = 6;
            this.feetPaintedLabel.Text = "Total square feet to be painted:";
            // 
            // gallonsNeededLabel
            // 
            this.gallonsNeededLabel.AutoSize = true;
            this.gallonsNeededLabel.Location = new System.Drawing.Point(14, 158);
            this.gallonsNeededLabel.Name = "gallonsNeededLabel";
            this.gallonsNeededLabel.Size = new System.Drawing.Size(172, 13);
            this.gallonsNeededLabel.TabIndex = 7;
            this.gallonsNeededLabel.Text = "Number of gallons of paint needed:";
            // 
            // hoursLaborLabel
            // 
            this.hoursLaborLabel.AutoSize = true;
            this.hoursLaborLabel.Location = new System.Drawing.Point(71, 188);
            this.hoursLaborLabel.Name = "hoursLaborLabel";
            this.hoursLaborLabel.Size = new System.Drawing.Size(115, 13);
            this.hoursLaborLabel.TabIndex = 8;
            this.hoursLaborLabel.Text = "Hours of labor needed:";
            // 
            // costPaintLabel
            // 
            this.costPaintLabel.AutoSize = true;
            this.costPaintLabel.Location = new System.Drawing.Point(117, 218);
            this.costPaintLabel.Name = "costPaintLabel";
            this.costPaintLabel.Size = new System.Drawing.Size(69, 13);
            this.costPaintLabel.TabIndex = 9;
            this.costPaintLabel.Text = "Cost of paint:";
            // 
            // costLaborLabel
            // 
            this.costLaborLabel.AutoSize = true;
            this.costLaborLabel.Location = new System.Drawing.Point(113, 248);
            this.costLaborLabel.Name = "costLaborLabel";
            this.costLaborLabel.Size = new System.Drawing.Size(73, 13);
            this.costLaborLabel.TabIndex = 10;
            this.costLaborLabel.Text = "Cost of Labor:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(128, 280);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 11;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // sqrFeetCalc
            // 
            this.sqrFeetCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqrFeetCalc.Location = new System.Drawing.Point(192, 128);
            this.sqrFeetCalc.Name = "sqrFeetCalc";
            this.sqrFeetCalc.Size = new System.Drawing.Size(100, 23);
            this.sqrFeetCalc.TabIndex = 12;
            // 
            // numGallonCalc
            // 
            this.numGallonCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numGallonCalc.Location = new System.Drawing.Point(192, 158);
            this.numGallonCalc.Name = "numGallonCalc";
            this.numGallonCalc.Size = new System.Drawing.Size(100, 23);
            this.numGallonCalc.TabIndex = 13;
            // 
            // hoursLaborCalc
            // 
            this.hoursLaborCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursLaborCalc.Location = new System.Drawing.Point(192, 188);
            this.hoursLaborCalc.Name = "hoursLaborCalc";
            this.hoursLaborCalc.Size = new System.Drawing.Size(100, 23);
            this.hoursLaborCalc.TabIndex = 14;
            // 
            // costPaintCalc
            // 
            this.costPaintCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintCalc.Location = new System.Drawing.Point(192, 218);
            this.costPaintCalc.Name = "costPaintCalc";
            this.costPaintCalc.Size = new System.Drawing.Size(100, 23);
            this.costPaintCalc.TabIndex = 15;
            // 
            // costLaborCalc
            // 
            this.costLaborCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLaborCalc.Location = new System.Drawing.Point(192, 248);
            this.costLaborCalc.Name = "costLaborCalc";
            this.costLaborCalc.Size = new System.Drawing.Size(100, 23);
            this.costLaborCalc.TabIndex = 16;
            // 
            // totalCostCalc
            // 
            this.totalCostCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostCalc.Location = new System.Drawing.Point(192, 280);
            this.totalCostCalc.Name = "totalCostCalc";
            this.totalCostCalc.Size = new System.Drawing.Size(100, 23);
            this.totalCostCalc.TabIndex = 17;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(142, 327);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 23);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 362);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCostCalc);
            this.Controls.Add(this.costLaborCalc);
            this.Controls.Add(this.costPaintCalc);
            this.Controls.Add(this.hoursLaborCalc);
            this.Controls.Add(this.numGallonCalc);
            this.Controls.Add(this.sqrFeetCalc);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.costLaborLabel);
            this.Controls.Add(this.costPaintLabel);
            this.Controls.Add(this.hoursLaborLabel);
            this.Controls.Add(this.gallonsNeededLabel);
            this.Controls.Add(this.feetPaintedLabel);
            this.Controls.Add(this.paintPriceTB);
            this.Controls.Add(this.numCoatsTB);
            this.Controls.Add(this.sqrFeetTB);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.numCoatsLabel);
            this.Controls.Add(this.sqrFeetLabel);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sqrFeetLabel;
        private System.Windows.Forms.Label numCoatsLabel;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.TextBox sqrFeetTB;
        private System.Windows.Forms.TextBox numCoatsTB;
        private System.Windows.Forms.TextBox paintPriceTB;
        private System.Windows.Forms.Label feetPaintedLabel;
        private System.Windows.Forms.Label gallonsNeededLabel;
        private System.Windows.Forms.Label hoursLaborLabel;
        private System.Windows.Forms.Label costPaintLabel;
        private System.Windows.Forms.Label costLaborLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label sqrFeetCalc;
        private System.Windows.Forms.Label numGallonCalc;
        private System.Windows.Forms.Label hoursLaborCalc;
        private System.Windows.Forms.Label costPaintCalc;
        private System.Windows.Forms.Label costLaborCalc;
        private System.Windows.Forms.Label totalCostCalc;
        private System.Windows.Forms.Button calculateButton;
    }
}

