using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Billing_Software
{
    public partial class Additem : Form
    {
        string conection = "Data Source=DESKTOP-FBLE67D;Initial Catalog=Aonedb;Integrated Security=True;";
        public Additem()
        {
            InitializeComponent();
        }
        //add button
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conection);
            try
            {
                if (string.IsNullOrEmpty(namet.Text))
                {
                    MessageBox.Show("enter item name, price and discount");
                }
                else
                {
                    if (string.IsNullOrEmpty(pricet.Text))
                    {
                        MessageBox.Show("enter price and discount");

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(discountt.Text))
                        {
                            MessageBox.Show("enter discount");

                        }
                        else
                        {
                            string query = "insert into AONE_TABLE values(@name,@price,@discount)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@name", namet.Text);
                            cmd.Parameters.AddWithValue("@price", pricet.Text);
                            cmd.Parameters.AddWithValue("@discount", discountt.Text);
                            con.Open();
                            int insert = cmd.ExecuteNonQuery();
                            if (insert > 0)
                            {
                                MessageBox.Show("data inserted!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                namet.Clear();
                                pricet.Clear();
                                discountt.Clear();
                                namet.Focus();
                            }
                            else
                            {
                                MessageBox.Show("data not inserted!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }
            catch
            {

                con.Close();
            }
        }

        private void pricet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void discountt_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
