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

namespace Billing_Software
{
    public partial class dataview : Form
    {
        String conection = "Data Source=DESKTOP-FBLE67D;Initial Catalog = Aonedb; Integrated Security = True;";
        public dataview()
        {
            InitializeComponent();

        }

        private void dataview_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Additem ad = new Additem();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_item ei = new edit_item();
            ei.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_item ei = new edit_item();
            ei.ShowDialog();
        }

        private void dataview_Activated(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conection);
            string query = "select * from AONE_TABLE";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
