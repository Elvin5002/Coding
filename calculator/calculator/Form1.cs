using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    

    public partial class Form1 : Form
    {
        bool optdurum = false;
        double netice = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void reqemclick(object sender, EventArgs e)
        {
            if (tb1.Text == "0" || optdurum == true) tb1.Clear();
            optdurum = false;
            Button btn = (Button)sender;
            tb1.Text += btn.Text;
        }

        private void hesab(object sender, EventArgs e)
        {
            optdurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lb.Text = lb.Text + " " + tb1.Text + " " + yeniOpt;
            
            switch (opt)
            {
                case "+": tb1.Text = (netice + Double.Parse(tb1.Text)).ToString(); break;
                case "-": tb1.Text = (netice - Double.Parse(tb1.Text)).ToString(); break;
                case "*": tb1.Text = (netice * Double.Parse(tb1.Text)).ToString(); break;
                case "/": tb1.Text = (netice / Double.Parse(tb1.Text)).ToString(); break;
            }
            netice = Double.Parse(tb1.Text);
            tb1.Text = netice.ToString();
            opt = yeniOpt;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tb1.Text = "0";
            lb.Text = "";
            netice = 0;
            opt = "";
            optdurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lb.Text = "";
            optdurum = true;

            switch (opt)
            {
                case "+": tb1.Text = (netice + Double.Parse(tb1.Text)).ToString(); break;
                case "-": tb1.Text = (netice - Double.Parse(tb1.Text)).ToString(); break;
                case "*": tb1.Text = (netice * Double.Parse(tb1.Text)).ToString(); break;
                case "/": tb1.Text = (netice / Double.Parse(tb1.Text)).ToString(); break;
            }

            netice = Double.Parse(tb1.Text);
            tb1.Text = netice.ToString();
            opt = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tb1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0")
            {
                tb1.Text = "0";
            }
            else if (optdurum == true)
            {
                tb1.Text = "0";
            }

            if (!tb1.Text.Contains("."))
            {
                tb1.Text += ",";
            }

            optdurum = false;
        }
    }
}
