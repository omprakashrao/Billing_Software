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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Billing_Software
{
    public partial class ragistor : Form
    {
        string connection = "Data Source=DESKTOP-FBLE67D;Integrated Security=True;";
        public static string username = "";
        public static string pass = "";
        public ragistor()
        {
            InitializeComponent();
            name.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            loginformcs log = new loginformcs();
            log.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string qiery = "insert into singup values(@name,@surname,@gender,@age,@address,@email,@password)";
                SqlCommand cmd = new SqlCommand(qiery, con);
                if (string.IsNullOrEmpty(name.Text) == true)
                {
                    MessageBox.Show("name column not empty");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@name", name.Text);
                }

                cmd.Parameters.AddWithValue("@surname", surname.Text);
                if (string.IsNullOrEmpty(gender.Text) == true)
                {
                    MessageBox.Show("select gender ");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gender", gender.Text);
                }
                if (string.IsNullOrEmpty(age.Text) == true)
                {
                    MessageBox.Show("age column not empty");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@age", age.Text);
                }
                if (string.IsNullOrEmpty(address.Text) == true)
                {
                    MessageBox.Show("address column not empty");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@address", address.Text);
                }
                if (validate_emailaddress.IsMatch(email.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    email.Focus();
                    return;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    MessageBox.Show("Email Address is valid.");

                }
                if (string.IsNullOrEmpty(password.Text) == true)
                {
                    MessageBox.Show("name column not empty");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@password", password.Text);
                }
                con.Open();
                int insert = cmd.ExecuteNonQuery();
                if (insert > 0)
                {
                    username = name.Text;
                    pass = password.Text;
                    MessageBox.Show("inserted success username=" + username + " password =" + pass, "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    loginformcs ragistor = new loginformcs();
                    ragistor.ShowDialog();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        private void surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
