using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Metadata;
using System.Configuration;

namespace Billing_Software
{
    public partial class Form1 : Form
    {
        //string conection = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        String conection = "Data Source=DESKTOP-FBLE67D;Initial Catalog = Aonedb; Integrated Security = True;";

        int sr = 0;
        int fcost = 0;
        int getpricevalue = 0;
        int disc = 0;
        int chnage = 0;
        int bill = 0;
        public Form1()
        {
            InitializeComponent();
            getitem();
            user.Text = loginformcs.username;
            qunt.ReadOnly = true;
            amountpaid.ReadOnly = true;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "S.NO.";
            dataGridView1.Columns[1].Name = "ITEM NAME";
            dataGridView1.Columns[2].Name = "UNIT PRICE";
            dataGridView1.Columns[3].Name = "DISCOUNT PER ITEM";
            dataGridView1.Columns[4].Name = "QUANTITY";
            dataGridView1.Columns[5].Name = "SUB TOTAL";
            dataGridView1.Columns[6].Name = "TAX";
            dataGridView1.Columns[7].Name = "TOTAL COST";
            getinvoice();
        }
        void gridviewadddata(String sno, String item_name, String unit_price, String dis_per_item, String quaninty, String sub_total, String tax, String total_cost)
        {
            String[] row = { sno, item_name, unit_price, dis_per_item, quaninty, sub_total, tax, total_cost };
            dataGridView1.Rows.Add(row);
        }
        void getitem()
        {
            selectitem.Items.Clear();
            SqlConnection con = new SqlConnection(conection);
            String query = "select * from AONE_TABLE";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String item_names = dr.GetString(1);

                selectitem.Items.Add(item_names);
            }
            selectitem.Sorted = true;
            con.Close();

        }
        void getprice()
        {
            SqlConnection con = new SqlConnection(conection);
            String Query = "select item_price from AONE_TABLE where item_name=@name";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", selectitem.SelectedItem.ToString());


            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                getpricevalue = Convert.ToInt32(dt.Rows[0]["item_price"]);
            }
            price.Text = getpricevalue.ToString();

        }
        private void selectitem_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        void getdis()
        {
            SqlConnection con = new SqlConnection(conection);
            String Query = "select item_discount from AONE_TABLE where item_name=@name";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", selectitem.SelectedItem.ToString());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                disc = Convert.ToInt32(dt.Rows[0]["item_discount"]);
            }
            discount.Text = disc.ToString();
        }

        void reset2()
        {
            selectitem.Text = "";
            price.Clear();
            qunt.Clear();
            discount.Clear();
            tax.Clear();
            subtotal.Clear();
            totalcost.Clear();
            finalcost.Clear();
            amountpaid.Clear();
            change.Clear();
            amountpaid.ReadOnly = true;
            dataGridView1.Rows.Clear();
            sr = 0;
        }
        void addreset()
        {
            price.Clear();
            qunt.Clear();
            discount.Clear();
            tax.Clear();
            subtotal.Clear();
            totalcost.Clear();
            qunt.ReadOnly = true;
        }
        void item_chnage_price_chnage()
        {
            if (string.IsNullOrEmpty(qunt.Text) == true)
            {
                tax.Text = "";
                subtotal.Text = "";
                totalcost.Text = "";
            }
            else
            {
                int qun = Convert.ToInt32(qunt.Text);
                int unitprice = Convert.ToInt32(price.Text);
                int disc = Convert.ToInt32(discount.Text);
                int total = unitprice * qun;
                int subto = total - disc * qun;
                subtotal.Text = subto.ToString();
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }



        private void qunt_TextChanged(object sender, EventArgs e)
        {


            item_chnage_price_chnage();

        }

        private void tax_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotal_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subtotal.Text) == true)
            {

            }
            else
            {
                int subtota = Convert.ToInt32(subtotal.Text);
                int taxx = (int)(subtota * 0.18);
                tax.Text = taxx.ToString();
                int tc = subtota + (int)(subtota * 0.18);
                totalcost.Text = tc.ToString();
            }



        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(qunt.Text))
                {
                    MessageBox.Show("plz add quantity");

                }

                else
                {
                    if (string.IsNullOrEmpty(qunt.Text) == false)
                    {
                        gridviewadddata((++sr).ToString(), selectitem.Text.ToString(), price.Text.ToString(), discount.Text.ToString(), qunt.Text.ToString(), subtotal.Text.ToString(), tax.Text.ToString(), totalcost.Text.ToString());
                        fcost = fcost + Convert.ToInt32(totalcost.Text);
                        finalcost.Text = fcost.ToString();
                        addreset();
                        amountpaid.ReadOnly = false;
                        selectitem.Enabled = true;
                    }

                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("plz add quantity");
            }
        }

        private void amountpaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountpaid.Text) == true)
            {
                change.Text = "";
            }
            else
            {

                int ap = Convert.ToInt32(amountpaid.Text);
                int fc = Convert.ToInt32(finalcost.Text);
                chnage = ap - fc;
                change.Text = chnage.ToString();

            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset2();
            qunt.ReadOnly = true;


        }
        private void getinvoice()
        {
            SqlConnection cone = new SqlConnection(conection);
            string query = "select invoice_num from addinvoice";
            SqlDataAdapter sda = new SqlDataAdapter(query, cone);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            if (ds.Rows.Count < 1)
            {
                invoice.Text = "101";
            }
            else
            {
                string query2 = "select max(invoice_num) from addinvoice";
                SqlCommand cmd = new SqlCommand(query2, cone);
                cone.Open();
                bill = Convert.ToInt32(cmd.ExecuteScalar());
                bill = bill + 1;
                invoice.Text = bill.ToString();
                cone.Close();
            }
        }
        private void insertinvoicedata()
        {
            SqlConnection cone = new SqlConnection(conection);
            string query = "insert into addinvoice values(@invoice_num,@username,@datetime,@finalcost)";
            SqlCommand cmd = new SqlCommand(query, cone);
            cmd.Parameters.AddWithValue("@invoice_num", invoice.Text);
            cmd.Parameters.AddWithValue("@username", user.Text);
            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@finalcost", finalcost.Text);
            cone.Open();
            int insert = cmd.ExecuteNonQuery();
            cone.Close();
            insertorderdetail();
            if (insert > 0)
            {
                MessageBox.Show("data inserted", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("data not inserted", "faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //insert button
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(finalcost.Text) == true)
            {
                MessageBox.Show("plz item add after insert data to table");
            }
            else
            {
                insertinvoicedata();
                reset2();
                getinvoice();
                selectitem.Enabled = true;

            }

        }

        int getLastInvoiceId()
        {
            SqlConnection cone = new SqlConnection(conection);
            string query = "select max(invoice_num) from addinvoice";
            SqlCommand cmd = new SqlCommand(query, cone);
            cone.Open();
            int getinvoice = Convert.ToInt32(cmd.ExecuteScalar());
            cone.Close();
            return getinvoice;
        }

        void insertorderdetail()
        {
            SqlConnection cone = new SqlConnection(conection);
            try
            {
                int insert = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string query = "insert into orderTable values(@invoice_id,@item_name,@unit_price,@discount_peritem,@quantity,@subtotal,@tax,@total_cost)";
                    SqlCommand cmd = new SqlCommand(query, cone);
                    cmd.Parameters.AddWithValue("@invoice_id", getLastInvoiceId());
                    cmd.Parameters.AddWithValue("@item_name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@unit_price", dataGridView1.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@discount_peritem", dataGridView1.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@subtotal", dataGridView1.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@tax", dataGridView1.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@total_cost", dataGridView1.Rows[i].Cells[7].Value);
                    cone.Open();
                    insert = insert + cmd.ExecuteNonQuery();
                    cone.Close();

                }

            }
            catch
            {


            }
        }

        private void qunt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void amountpaid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void selectitem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            item_chnage_price_chnage();
            getprice();
            getdis();
            qunt.ReadOnly = false;


        }

        //print preview button
        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Screenshot__1_;
            Image img = bmp;
            e.Graphics.DrawImage(img, 30, 5, 800, 250);
            e.Graphics.DrawString("User :" + invoice.Text, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(30, 250));
            e.Graphics.DrawString("User Name:" + user.Text, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(30, 300));
            e.Graphics.DrawString("Date:" + DateTime.Now.ToShortDateString(), new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(30, 350));
            e.Graphics.DrawString("Date:" + DateTime.Now.ToShortTimeString(), new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(30, 400));
            e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(3, 450));
            e.Graphics.DrawString("Item", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(20, 480));
            e.Graphics.DrawString("Quantity", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(250, 480));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 480));
            e.Graphics.DrawString("Discount", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(650, 480));
            e.Graphics.DrawString("--------------------------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(3, 490));

            //item name ko get karaya
            int incressitemnamegap = 530;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(20, incressitemnamegap));
                        incressitemnamegap = incressitemnamegap + 30;
                    }
                    catch
                    {


                    }
                }
            }

            //item price get
            int incress_qunt_gap = 530;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(270, incress_qunt_gap));
                        incress_qunt_gap = incress_qunt_gap + 30;
                    }
                    catch
                    {


                    }
                }
            }

            //get unit price
            int incress_unitprice_gap = 530;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(450, incress_unitprice_gap));
                        incress_unitprice_gap = incress_unitprice_gap + 30;
                    }
                    catch
                    {


                    }
                }
            }

            //get discount value
            int incress_discout_gap = 530;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(670, incress_discout_gap));
                        incress_discout_gap = incress_discout_gap + 30;
                    }
                    catch
                    {


                    }
                }
            }

            e.Graphics.DrawString("------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(3, 880));
            e.Graphics.DrawString("Sub Total:", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 910));
            int subtoatal_value = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        subtoatal_value = subtoatal_value + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());

                    }
                    catch
                    {


                    }
                }
                e.Graphics.DrawString(subtoatal_value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 910));
            }
            //get tax
            e.Graphics.DrawString("Tax:", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 940));
            int tax_value = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        tax_value = tax_value + Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());

                    }
                    catch
                    {


                    }
                }
                e.Graphics.DrawString(tax_value.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 940));
            }
            e.Graphics.DrawString("Final Cost:   " + finalcost.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 970));
            e.Graphics.DrawString("------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(3, 980));
            e.Graphics.DrawString("Amount Paid:   " + amountpaid.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1020));
            e.Graphics.DrawString("Change:   " + change.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(30, 1050));
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additem ad = new Additem();

            ad.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            getitem();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_item edit = new edit_item();
            edit.ShowDialog();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataview dt = new dataview();
            dt.ShowDialog();
        }

        private void detailsSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details d = new Details();
            d.ShowDialog();
        }
    }
}
