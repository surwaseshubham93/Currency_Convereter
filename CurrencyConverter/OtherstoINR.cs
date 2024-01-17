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
    public partial class OtherstoINR : Form
    {
        SqlConnection conn;
        public OtherstoINR()
        {
            InitializeComponent();
            get();
        }

        public void get()
        {
            conn = new SqlConnection("Data Source = SHUBHAM; Initial Catalog = CurrencyConverter; Integrated Security = True");
            conn.Open();

            SqlDataAdapter ad = new SqlDataAdapter("Select country_name from RatescomparedtoINR", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            countrycombobox.DisplayMember = "Country_Name";
            countrycombobox.ValueMember = "Country_Name";
            countrycombobox.DataSource = dt;
        }
                
        private void countrycombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection("Data Source = SHUBHAM; Initial Catalog = CurrencyConverter;Integrated Security = True");
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from RatescomparedtoINR where country_name = @country_name", conn);
                cmd.Parameters.AddWithValue("@country_name",countrycombobox.SelectedValue);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    currencytext.Text = dr["currency"].ToString();
                    ratetext.Text = dr["international_rate"].ToString();

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

        private void converttoinrbtn_Click(object sender, EventArgs e)
        {
            //double x = Convert.ToDouble(enteramounttext.Text) * Convert.ToDouble(ratetext.Text);
            float x = float.Parse(enteramounttext.Text) * float.Parse(ratetext.Text);
            double d = Math.Ceiling(x);
            resulttext.Text = d.ToString();
        }

        private void tohomebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void OtherstoINR_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
