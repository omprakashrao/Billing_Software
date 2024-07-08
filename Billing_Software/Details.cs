global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Data;
global using System.Drawing;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using System.Windows.Forms;
global using System.Data.SqlClient;


namespace Billing_Software
{
    public partial class Details : Form
    {
        string conection = "Data Source=DESKTOP-FBLE67D;Initial Catalog=Aonedb;Integrated Security=True;";
        public Details()
        {
            InitializeComponent();
            Bindgridview();
            label4.Visible = false;
            label3.Visible = false;
        }
        void Bindgridview()
        {
            SqlConnection con = new SqlConnection(conection);
            string query = "getbothtabledata";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conection);
            try
            {
                if (string.IsNullOrEmpty(sbox.Text))
                {
                    MessageBox.Show("plz enter invoice num");
                }
                else
                {
                    string query = "getbothtabaledatabyinvoice";
                    // string query = "getbothtabledata";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoiceid", sbox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[10].Visible = false;
                    label4.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
                    label4.Visible = true;
                    label3.Visible = true;

                }
            }
            catch
            {


            }
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

        private void sbox_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
        }

        private void Seachbydate_Click(object sender, EventArgs e)
        {


               // Console.WriteLine(dateTimePicker1.Value);
            try
            {
                SqlConnection con = new SqlConnection(conection);
                string query = "select * from addinvoice where datetime between @firstdate and @lastdate";

               // SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@firstdate", dateTimePicker1.Value);
                sda.SelectCommand.Parameters.AddWithValue("@lastdate", dateTimePicker2.Value);
               // sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {


            }





        }

        private void reset_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Text = DateTime.Now.ToString();
           // dateTimePicker2.Text = DateTime.Now.ToString();
            Bindgridview();

        }
    }
}
