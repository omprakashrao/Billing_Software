using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Software
{
    public partial class loginformcs : Form
    {
       
        string connection = "Data Source=DESKTOP-FBLE67D;Integrated Security=True;";
        public static String username = "";
        public static string pass = "";
        public loginformcs()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(connection);
            String query = "select * from singup where name=@name and password=@pass";
            SqlCommand cmd = new SqlCommand(query, cone);
            cone.Open();
            cmd.Parameters.AddWithValue("@name",un.Text);
            cmd.Parameters.AddWithValue("@pass", pw.Text);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows == true)
            {
                username = un.Text.ToString();
                pass= pw.Text.ToString();
                MessageBox.Show("login successful usename=" + username +" password="+pass, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 mainform = new Form1();
                mainform.ShowDialog();
            }
            else
            {
                MessageBox.Show("login failed", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cone.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //bool check = true;
            if (checkBox1.Checked == true)
            {
                pw.UseSystemPasswordChar = false;

            }
            else
            {
                pw.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            username = un.Text.ToString();
            ragistor ragistor = new ragistor();
            ragistor.ShowDialog();
        }
    }
}
