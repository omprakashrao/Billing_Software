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
using System.Diagnostics;

namespace Billing_Software
{

    public partial class edit_item : Form
    {
        string conection = "Data Source=DESKTOP-FBLE67D;Initial Catalog=Aonedb;Integrated Security=True;";

        int getpricevalue = 0;
        int disc = 0;

        public edit_item()
        {
            InitializeComponent();
            select();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void namet_TextChanged(object sender, EventArgs e)
        {

        }
        //update button
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conection);
            try
            {
                if (string.IsNullOrEmpty(itemname.Text))
                {
                    MessageBox.Show("plz select item name in item list");
                }
                else
                {
                    string query = "update AONE_TABLE set item_name=@name, item_price=@price,item_discount=@discount where item_id=@id;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", itemname.Text);
                    cmd.Parameters.AddWithValue("@price", pricet.Text);
                    cmd.Parameters.AddWithValue("@discount", discountt.Text);
                    con.Open();
                    int insert = cmd.ExecuteNonQuery();
                    if (insert > 0)
                    {
                        MessageBox.Show("data updated!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pricet.Clear();
                        discountt.Clear();
                        id.Clear();
                        itemname.Text = "";
                        itemname.Focus();
                    }
                    else
                    {
                        MessageBox.Show("data not updated!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

                con.Close();
            }
        }

        private void select()
        {
            SqlConnection con = new SqlConnection(conection);
            String query = "select * from AONE_TABLE";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String item_names = dr.GetString(1);

                itemname.Items.Add(item_names);
            }

            itemname.Sorted = true;
            con.Close();

        }

        void getprice()
        {
            SqlConnection con = new SqlConnection(conection);

            try
            {
                if (string.IsNullOrEmpty(itemname.Text))
                {

                }
                else
                {
                    string Query = "select item_price from AONE_TABLE where item_name=@name";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    sda.SelectCommand.Parameters.AddWithValue("@name", itemname.SelectedItem.ToString());


                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        getpricevalue = Convert.ToInt32(dt.Rows[0]["item_price"]);
                    }
                    pricet.Text = getpricevalue.ToString();
                }
            }
            catch
            {


            }
        }

        void getdis()
        {
            if (string.IsNullOrEmpty(itemname.Text))
            {
            }
            else
            {
                SqlConnection con = new SqlConnection(conection);
                String Query = "select item_discount from AONE_TABLE where item_name=@name";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", itemname.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    disc = Convert.ToInt32(dt.Rows[0]["item_discount"]);
                }
                discountt.Text = disc.ToString();
            }
        }
        void getid()
        {
            SqlConnection con = new SqlConnection(conection);

            try
            {
                if (string.IsNullOrEmpty(itemname.Text))
                {

                }
                else
                {
                    string Query = "select item_id from AONE_TABLE where item_name=@name";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    sda.SelectCommand.Parameters.AddWithValue("@name", itemname.SelectedItem.ToString());


                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        getpricevalue = Convert.ToInt32(dt.Rows[0]["item_id"]);
                    }
                    id.Text = getpricevalue.ToString();
                }
            }
            catch
            {


            }
        }

        private void itemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
            getdis();
            getid();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conection);
            try
            {
                if (string.IsNullOrEmpty(itemname.Text))
                {
                    MessageBox.Show("plz enter item name from item list");
                }
                else
                {
                    string query = "delete from AONE_TABLE where item_id=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id.Text);

                    con.Open();
                    int insert = cmd.ExecuteNonQuery();
                    if (insert > 0)
                    {
                        MessageBox.Show("data Deleted!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pricet.Clear();
                        discountt.Clear();
                        id.Clear();
                        itemname.Text = "";
                        itemname.Focus();
                    }
                    else
                    {
                        MessageBox.Show("data not Deleted!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
