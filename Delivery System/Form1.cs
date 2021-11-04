using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Delivery_System
{
    public partial class Form1 : Form
    {
        ////Form1
        public Form1()
        {
            InitializeComponent();
        }

        ////Log in Method
        public void Log_in()
        {
            ////Virable Constring
            string connstr = "server=localhost;user=root;database=dbaccountsystem;port=3306;password=admin";
            MySqlConnection con = new MySqlConnection(connstr);
            ////Try Catch and Open MySql / Close MySql
            try
            {
                MySqlCommand cmd = new MySqlCommand("Select * from loginsystem where UserName=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Username", TBusername.Text);
                cmd.Parameters.AddWithValue("@Password", TBpassword.Text);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Successfully Sign In!", "Windows!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 fm2 = new Form2();
                    fm2.Show();
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "Windows", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TBusername.Text = string.Empty;
                TBpassword.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("errrror"+ "Windows");
            }
        }
        ////Event Log in Buttom
        private void button1_Click(object sender, EventArgs e)
        {
            Log_in();
        }
        ////Event Cancel Buttom
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}