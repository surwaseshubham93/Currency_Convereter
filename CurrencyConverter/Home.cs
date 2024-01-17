using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toinrbtn_Click(object sender, EventArgs e)
        {
            OtherstoINR toinr = new OtherstoINR();
            this.Hide();
            toinr.Show();
            
        }

        private void toothers_Click(object sender, EventArgs e)
        {
            INRtoOthers toothers = new INRtoOthers();
            this.Hide();
            toothers.Show();
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
