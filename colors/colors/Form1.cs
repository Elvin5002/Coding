using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        color r = new color();
        private void Form1_Load(object sender, EventArgs e)
        { 

            label1.Text = "Arxafon rengi ne rengdedir?";

            int num1;
            int num2;
            int num3;
 
            for (int i = 0; i < 100; i++)
            {
                num1 = rand.Next(0, 255);
                num2 = rand.Next(0, 255);
                num3 = rand.Next(0, 255);
                this.BackColor = Color.FromArgb(num1, num2, num3);
            }

            int a = rand.Next(r.answer.Count);    
            int b = rand.Next(r.answer.Count);
            int c = rand.Next(r.answer.Count);

            if(a == b || a == c || b == c)
            {
                a = rand.Next(r.answer.Count);
                b = rand.Next(r.answer.Count);
                c = rand.Next(r.answer.Count);
            }
            
            radioButton1.Text = r.answer[a];
            radioButton2.Text = r.answer[b];
            radioButton3.Text = r.answer[c];
        }

        private void rengdey(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int num3;

            for (int i = 0; i < 100; i++)
            {
                num1 = rand.Next(0, 255);
                num2 = rand.Next(0, 255);
                num3 = rand.Next(0, 255);
                this.BackColor = Color.FromArgb(num1, num2, num3);
            }

            int a = rand.Next(r.answer.Count);
            int b = rand.Next(r.answer.Count);
            int c = rand.Next(r.answer.Count);

            if (a == b || a == c || b == c)
            {
                a = rand.Next(r.answer.Count);
                b = rand.Next(r.answer.Count);
                c = rand.Next(r.answer.Count);
            }

            radioButton1.Text = r.answer[a];
            radioButton2.Text = r.answer[b];
            radioButton3.Text = r.answer[c];
        }
    }
}
