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

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sqlcon sql = new Sqlcon();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.ExecuteReader("Select * from Universities");
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            SqlCommand cmd = new SqlCommand("insert into task (Fin, Ad, Soyad, Ata) values (@pFin, @pName, @pSurname, @pDad)", Sqlcon.sqlConnection);
            
            cmd.Parameters.AddWithValue("@pFin", textBox1.Text);
            cmd.Parameters.AddWithValue("@pName", textBox2.Text);
            cmd.Parameters.AddWithValue("@pSurname", textBox3.Text);
            cmd.Parameters.AddWithValue("@pDad", textBox4.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            */

            MessageBox.Show(Sqlcon.ExecuteNonQuery("insert into Universities (Name,Amount) values ('BMU',1200)").ToString());
        }
    }
}
