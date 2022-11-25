using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class elave_et : Form
    {
        public elave_et()
        {
            InitializeComponent();
        }
        Db dbcon = new Db();
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string price = textBox1.Text;
            string quan = textBox1.Text;
            string status = textBox1.Text;
            try
            {
                dbcon.ExecuteNonQuery(string.Format("insert into Product (Name, Price, Quantity, Status) values ({0}, {1}, {2}, {3})", name, price, quan, status));

            }
            catch (Exception ex)
            {
                StreamWriter s = new StreamWriter(@"log.txt");
                s.WriteLine(ex.ToString());
                s.Close();
            }
                
        }
       
        private void elave_et_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
                dbcon.sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("insert into Product (Name, Price, Quantity, Status) values (@pName, @price, @quan, @status)", dbcon.sqlConnection);
                cmd.Parameters.AddWithValue("@pName", textBox1.Text);
                cmd.Parameters.AddWithValue("@price", textBox2.Text);
                cmd.Parameters.AddWithValue("@quan", textBox3.Text);
                cmd.Parameters.AddWithValue("@status", textBox4.Text);
                cmd.Dispose();
                dbcon.sqlConnection.Close();*/
