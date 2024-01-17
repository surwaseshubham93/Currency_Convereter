namespace CurrencyConverter
{
    partial class INRtoOthers
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
            this.label5 = new System.Windows.Forms.Label();
            this.enteramounttext = new System.Windows.Forms.TextBox();
            this.ratetext = new System.Windows.Forms.TextBox();
            this.currencytext = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.Label();
            this.resulttext = new System.Windows.Forms.TextBox();
            this.inrtoothersbtn = new System.Windows.Forms.Button();
            this.rate = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.enteramount = new System.Windows.Forms.Label();
            this.countrycombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "INR to Other Currencies";
            // 
            // enteramounttext
            // 
            this.enteramounttext.Location = new System.Drawing.Point(562, 318);
            this.enteramounttext.Name = "enteramounttext";
            this.enteramounttext.Size = new System.Drawing.Size(246, 26);
            this.enteramounttext.TabIndex = 22;
            // 
            // ratetext
            // 
            this.ratetext.Location = new System.Drawing.Point(562, 247);
            this.ratetext.Name = "ratetext";
            this.ratetext.Size = new System.Drawing.Size(246, 26);
            this.ratetext.TabIndex = 21;
            // 
            // currencytext
            // 
            this.currencytext.Location = new System.Drawing.Point(562, 187);
            this.currencytext.Name = "currencytext";
            this.currencytext.Size = new System.Drawing.Size(246, 26);
            this.currencytext.TabIndex = 20;
            // 
            // amt
            // 
            this.amt.AutoSize = true;
            this.amt.Location = new System.Drawing.Point(378, 495);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(142, 20);
            this.amt.TabIndex = 19;
            this.amt.Text = "Converted Amount";
            // 
            // resulttext
            // 
            this.resulttext.Location = new System.Drawing.Point(617, 492);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(157, 26);
            this.resulttext.TabIndex = 18;
            // 
            // inrtoothersbtn
            // 
            this.inrtoothersbtn.Location = new System.Drawing.Point(382, 397);
            this.inrtoothersbtn.Name = "inrtoothersbtn";
            this.inrtoothersbtn.Size = new System.Drawing.Size(148, 52);
            this.inrtoothersbtn.TabIndex = 17;
            this.inrtoothersbtn.Text = "Convert";
            this.inrtoothersbtn.UseVisualStyleBackColor = true;
            this.inrtoothersbtn.Click += new System.EventHandler(this.inrtoothersbtn_Click);
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Location = new System.Drawing.Point(298, 253);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(258, 20);
            this.rate.TabIndex = 16;
            this.rate.Text = "International rate Compared to INR";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(378, 187);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(72, 20);
            this.currency.TabIndex = 15;
            this.currency.Text = "Currency";
            // 
            // enteramount
            // 
            this.enteramount.AutoSize = true;
            this.enteramount.Location = new System.Drawing.Point(378, 318);
            this.enteramount.Name = "enteramount";
            this.enteramount.Size = new System.Drawing.Size(108, 20);
            this.enteramount.TabIndex = 14;
            this.enteramount.Text = "Enter Amount";
            // 
            // countrycombobox
            // 
            this.countrycombobox.FormattingEnabled = true;
            this.countrycombobox.Location = new System.Drawing.Point(562, 121);
            this.countrycombobox.Name = "countrycombobox";
            this.countrycombobox.Size = new System.Drawing.Size(246, 28);
            this.countrycombobox.TabIndex = 13;
            this.countrycombobox.SelectionChangeCommitted += new System.EventHandler(this.countrybox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Country";
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(611, 397);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(181, 51);
            this.homebtn.TabIndex = 24;
            this.homebtn.Text = "Back to Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // INRtoOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 571);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enteramounttext);
            this.Controls.Add(this.ratetext);
            this.Controls.Add(this.currencytext);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.resulttext);
            this.Controls.Add(this.inrtoothersbtn);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.enteramount);
            this.Controls.Add(this.countrycombobox);
            this.Controls.Add(this.label1);
            this.Name = "INRtoOthers";
            this.Text = "INRtoOthers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.INRtoOthers_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enteramounttext;
        private System.Windows.Forms.TextBox ratetext;
        private System.Windows.Forms.TextBox currencytext;
        private System.Windows.Forms.Label amt;
        private System.Windows.Forms.TextBox resulttext;
        private System.Windows.Forms.Button inrtoothersbtn;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label currency;
        private System.Windows.Forms.Label enteramount;
        private System.Windows.Forms.ComboBox countrycombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homebtn;
    }
}