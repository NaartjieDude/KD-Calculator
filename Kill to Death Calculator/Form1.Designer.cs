namespace Kill_to_Death_Calculator
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.killsBox = new System.Windows.Forms.TextBox();
            this.deathsBox = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ratioLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // killsBox
            // 
            this.killsBox.Location = new System.Drawing.Point(69, 16);
            this.killsBox.Name = "killsBox";
            this.killsBox.Size = new System.Drawing.Size(95, 20);
            this.killsBox.TabIndex = 0;
            // 
            // deathsBox
            // 
            this.deathsBox.Location = new System.Drawing.Point(69, 48);
            this.deathsBox.Name = "deathsBox";
            this.deathsBox.Size = new System.Drawing.Size(95, 20);
            this.deathsBox.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(24, 94);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(149, 38);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate!";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your K/D ratio is:";
            // 
            // ratioLabel
            // 
            this.ratioLabel.AutoSize = true;
            this.ratioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratioLabel.Location = new System.Drawing.Point(20, 196);
            this.ratioLabel.Name = "ratioLabel";
            this.ratioLabel.Size = new System.Drawing.Size(0, 20);
            this.ratioLabel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kills";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Deaths";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = " kills to 1 death";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(140, 246);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(46, 23);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 281);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ratioLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.deathsBox);
            this.Controls.Add(this.killsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "K/D Ratio Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox killsBox;
        private System.Windows.Forms.TextBox deathsBox;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ratioLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAbout;
    }
}

