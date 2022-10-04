using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb4.Text = Convert.ToString(Convert.ToInt32(lb4.Text) - 1);
            DateTime start = new DateTime(2022, 1, 1);
            Random gen = new Random();
            int range = (DateTime.Today - start).Days;
            Random random = new Random();
            int r = random.Next(1, 10);
            var a  = new ArrayList();
            a.Add(r);

            //lb1.Items.Add(start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)));
            lb1.Items.Add(r);

            for(int i = 0; i < a.count(); i++)
            {
                if (lb1.Items[0] = a[i]) lb1.Items.Add("Bu masin daha once daxil olub");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb4.Text = Convert.ToString(Convert.ToInt32(lb4.Text) + 1);
           
            lb1.Items.Clear();
        }
    }
}
