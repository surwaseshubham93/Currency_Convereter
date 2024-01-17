namespace CurrencyConverter
{
    partial class Home
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
            this.header = new System.Windows.Forms.Label();
            this.toinrbtn = new System.Windows.Forms.Button();
            this.toothers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.IndianRed;
            this.header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header.Location = new System.Drawing.Point(455, 65);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(145, 20);
            this.header.TabIndex = 0;
            this.header.Text = "Currency Converter";
            // 
            // toinrbtn
            // 
            this.toinrbtn.Location = new System.Drawing.Point(426, 160);
            this.toinrbtn.Name = "toinrbtn";
            this.toinrbtn.Size = new System.Drawing.Size(196, 76);
            this.toinrbtn.TabIndex = 1;
            this.toinrbtn.Text = "Others to INR";
            this.toinrbtn.UseVisualStyleBackColor = true;
            this.toinrbtn.Click += new System.EventHandler(this.toinrbtn_Click);
            // 
            // toothers
            // 
            this.toothers.Location = new System.Drawing.Point(426, 321);
            this.toothers.Name = "toothers";
            this.toothers.Size = new System.Drawing.Size(196, 75);
            this.toothers.TabIndex = 2;
            this.toothers.Text = "INR to Others";
            this.toothers.UseVisualStyleBackColor = true;
            this.toothers.Click += new System.EventHandler(this.toothers_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 573);
            this.Controls.Add(this.toothers);
            this.Controls.Add(this.toinrbtn);
            this.Controls.Add(this.header);
            this.Name = "Home";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button toinrbtn;
        private System.Windows.Forms.Button toothers;
    }
}

