namespace Activity_8
{
    partial class Calc_Calories
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
            this.FatsTB = new System.Windows.Forms.TextBox();
            this.CarbsTB = new System.Windows.Forms.TextBox();
            this.CalcBTN = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.FatsLBL = new System.Windows.Forms.Label();
            this.CarbsLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FatsTB
            // 
            this.FatsTB.Location = new System.Drawing.Point(151, 12);
            this.FatsTB.Name = "FatsTB";
            this.FatsTB.Size = new System.Drawing.Size(100, 20);
            this.FatsTB.TabIndex = 0;
            // 
            // CarbsTB
            // 
            this.CarbsTB.Location = new System.Drawing.Point(151, 38);
            this.CarbsTB.Name = "CarbsTB";
            this.CarbsTB.Size = new System.Drawing.Size(100, 20);
            this.CarbsTB.TabIndex = 1;
            // 
            // CalcBTN
            // 
            this.CalcBTN.Location = new System.Drawing.Point(13, 64);
            this.CalcBTN.Name = "CalcBTN";
            this.CalcBTN.Size = new System.Drawing.Size(75, 23);
            this.CalcBTN.TabIndex = 2;
            this.CalcBTN.Text = "Calculate";
            this.CalcBTN.UseVisualStyleBackColor = true;
            this.CalcBTN.Click += new System.EventHandler(this.CalcBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(94, 64);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(75, 23);
            this.ResetBTN.TabIndex = 3;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(176, 64);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(75, 23);
            this.CloseBTN.TabIndex = 4;
            this.CloseBTN.Text = "Close";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // FatsLBL
            // 
            this.FatsLBL.AutoSize = true;
            this.FatsLBL.Location = new System.Drawing.Point(12, 15);
            this.FatsLBL.Name = "FatsLBL";
            this.FatsLBL.Size = new System.Drawing.Size(78, 13);
            this.FatsLBL.TabIndex = 5;
            this.FatsLBL.Text = "Grams of Fats?";
            // 
            // CarbsLBL
            // 
            this.CarbsLBL.AutoSize = true;
            this.CarbsLBL.Location = new System.Drawing.Point(12, 41);
            this.CarbsLBL.Name = "CarbsLBL";
            this.CarbsLBL.Size = new System.Drawing.Size(85, 13);
            this.CarbsLBL.TabIndex = 6;
            this.CarbsLBL.Text = "Grams of Carbs?";
            // 
            // Calc_Calories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 102);
            this.Controls.Add(this.CarbsLBL);
            this.Controls.Add(this.FatsLBL);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.CalcBTN);
            this.Controls.Add(this.CarbsTB);
            this.Controls.Add(this.FatsTB);
            this.Name = "Calc_Calories";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FatsTB;
        private System.Windows.Forms.TextBox CarbsTB;
        private System.Windows.Forms.Button CalcBTN;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label FatsLBL;
        private System.Windows.Forms.Label CarbsLBL;
    }
}

