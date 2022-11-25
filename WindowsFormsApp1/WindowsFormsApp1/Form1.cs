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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db data = new Db();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void satisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new satis();
            myForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)    
        {   
           
            var myForm = new elave_et();
            myForm.Show();
        }

        private void hesabatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new satis();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = data.ExecuteReader("Select * from product");
            }
            catch(Exception ex)
            {
                StreamWriter s = new StreamWriter(@"log.txt");
                s.WriteLine(ex.ToString());
                s.Close();
            }
            
        }

    }
}
