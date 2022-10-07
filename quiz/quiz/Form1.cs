using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        int duzgun = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sual.1")
            {
                label1.Text = "i++ ile ++i arasindaki ferq";
                checkBox1.Text = "Birincsi artirir amma hazirki qiymeti deyismir";
                checkBox2.Text = "Ikincsi artirir amma hazirki qiymeti deyismir";
                checkBox3.Text = "Her ikisi eyni ifadedir";
            }
            else
            if (comboBox1.Text == "Sual.2")
            {
                label1.Text = "Array nedir?";
                checkBox1.Text = "String";
                checkBox2.Text = "Array eyni veri tipindən çox sayda değişken demektir.";
                checkBox3.Text = "Integer";
            }
            else
            {
                label1.Text = "String ile Char arasindaki ferq";
                checkBox1.Text = "String məlumat növü Unicode simvollarından ibarət sətir qrupudur";
                checkBox2.Text = "Massiv";
                checkBox3.Text = "Her ikisi eyni ifadedir";
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(duzgun);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sual.1" && checkBox1.Checked) duzgun++;
            else
            if (comboBox1.Text == "Sual.2" && checkBox2.Checked) duzgun++;
            else
            if (comboBox1.Text == "Sual.3" && checkBox1.Checked) duzgun++;
        }
    }
}
