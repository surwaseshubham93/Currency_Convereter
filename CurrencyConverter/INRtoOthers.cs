using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class INRtoOthers : Form
    {
        SqlConnection conn;
        public INRtoOthers()
        {
            InitializeComponent();
            get();
        }

        public void get()
        {
            conn = new SqlConnection("Data Source = SHUBHAM; Initial Catalog = CurrencyConverter; Integrated Security = True");
            conn.Open();

            SqlDataAdapter ad = new SqlDataAdapter("Select Country_Name from RatescomparedtoINR", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            countrycombobox.DisplayMember = "Country_name";
            countrycombobox.ValueMember = "Country_Name";
            countrycombobox.DataSource = dt;

        }

        private void countrybox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source = SHUBHAM; Initial Catalog = CurrencyConverter; Integrated Security = True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * from RatescomparedtoINR where Country_Name = @Country_Name", conn);
                cmd.Parameters.AddWithValue("@Country_Name", countrycombobox.SelectedValue);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    currencytext.Text = dr["Currency"].ToString();
                    ratetext.Text = dr["International_Rate"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }

        }

        private void inrtoothersbtn_Click(object sender, EventArgs e)
        {
            float x = float.Parse(enteramounttext.Text)/float.Parse(ratetext.Text);
            double d = Math.Ceiling(x);
            resulttext.Text = d.ToString();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void INRtoOthers_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
