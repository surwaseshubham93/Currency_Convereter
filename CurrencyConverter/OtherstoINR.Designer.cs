namespace CurrencyConverter
{
    partial class OtherstoINR
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
            this.countrycombobox = new System.Windows.Forms.ComboBox();
            this.enteramount = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.converttoinrbtn = new System.Windows.Forms.Button();
            this.resulttext = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.Label();
            this.currencytext = new System.Windows.Forms.TextBox();
            this.ratetext = new System.Windows.Forms.TextBox();
            this.enteramounttext = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.tohomebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Country";
            // 
            // countrycombobox
            // 
            this.countrycombobox.FormattingEnabled = true;
            this.countrycombobox.Location = new System.Drawing.Point(380, 93);
            this.countrycombobox.Name = "countrycombobox";
            this.countrycombobox.Size = new System.Drawing.Size(246, 28);
            this.countrycombobox.TabIndex = 1;
            this.countrycombobox.SelectionChangeCommitted += new System.EventHandler(this.countrycombobox_SelectionChangeCommitted);
            // 
            // enteramount
            // 
            this.enteramount.AutoSize = true;
            this.enteramount.Location = new System.Drawing.Point(196, 290);
            this.enteramount.Name = "enteramount";
            this.enteramount.Size = new System.Drawing.Size(108, 20);
            this.enteramount.TabIndex = 2;
            this.enteramount.Text = "Enter Amount";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(196, 159);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(72, 20);
            this.currency.TabIndex = 3;
            this.currency.Text = "Currency";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Location = new System.Drawing.Point(116, 225);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(258, 20);
            this.rate.TabIndex = 4;
            this.rate.Text = "International rate Compared to INR";
            // 
            // converttoinrbtn
            // 
            this.converttoinrbtn.Location = new System.Drawing.Point(345, 367);
            this.converttoinrbtn.Name = "converttoinrbtn";
            this.converttoinrbtn.Size = new System.Drawing.Size(148, 52);
            this.converttoinrbtn.TabIndex = 5;
            this.converttoinrbtn.Text = "Convert";
            this.converttoinrbtn.UseVisualStyleBackColor = true;
            this.converttoinrbtn.Click += new System.EventHandler(this.converttoinrbtn_Click);
            // 
            // resulttext
            // 
            this.resulttext.Location = new System.Drawing.Point(435, 464);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(157, 26);
            this.resulttext.TabIndex = 6;
            // 
            // amt
            // 
            this.amt.AutoSize = true;
            this.amt.Location = new System.Drawing.Point(196, 467);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(113, 20);
            this.amt.TabIndex = 7;
            this.amt.Text = "Amount in INR";
            // 
            // currencytext
            // 
            this.currencytext.Location = new System.Drawing.Point(380, 159);
            this.currencytext.Name = "currencytext";
            this.currencytext.Size = new System.Drawing.Size(246, 26);
            this.currencytext.TabIndex = 8;
            // 
            // ratetext
            // 
            this.ratetext.Location = new System.Drawing.Point(380, 219);
            this.ratetext.Name = "ratetext";
            this.ratetext.Size = new System.Drawing.Size(246, 26);
            this.ratetext.TabIndex = 9;
            // 
            // enteramounttext
            // 
            this.enteramounttext.Location = new System.Drawing.Point(380, 290);
            this.enteramounttext.Name = "enteramounttext";
            this.enteramounttext.Size = new System.Drawing.Size(246, 26);
            this.enteramounttext.TabIndex = 10;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(326, 26);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(179, 20);
            this.header.TabIndex = 11;
            this.header.Text = "Other Currencies to INR";
            // 
            // tohomebtn
            // 
            this.tohomebtn.Location = new System.Drawing.Point(664, 367);
            this.tohomebtn.Name = "tohomebtn";
            this.tohomebtn.Size = new System.Drawing.Size(193, 52);
            this.tohomebtn.TabIndex = 12;
            this.tohomebtn.Text = "Back to Home";
            this.tohomebtn.UseVisualStyleBackColor = true;
            this.tohomebtn.Click += new System.EventHandler(this.tohomebtn_Click);
            // 
            // OtherstoINR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 568);
            this.Controls.Add(this.tohomebtn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.enteramounttext);
            this.Controls.Add(this.ratetext);
            this.Controls.Add(this.currencytext);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.resulttext);
            this.Controls.Add(this.converttoinrbtn);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.enteramount);
            this.Controls.Add(this.countrycombobox);
            this.Controls.Add(this.label1);
            this.Name = "OtherstoINR";
            this.Text = "Changing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherstoINR_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countrycombobox;
        private System.Windows.Forms.Label enteramount;
        private System.Windows.Forms.Label currency;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Button converttoinrbtn;
        private System.Windows.Forms.TextBox resulttext;
        private System.Windows.Forms.Label amt;
        private System.Windows.Forms.TextBox currencytext;
        private System.Windows.Forms.TextBox ratetext;
        private System.Windows.Forms.TextBox enteramounttext;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button tohomebtn;
    }
}