﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }

        private void satis_Load(object sender, EventArgs e)
        { 
            listView1.Columns.Add("Ad", 150);
            listView1.Columns.Add("Qiymet", 150);
            listView1.Columns.Add("Miqdar", 150);
            listView1.Columns.Add("Cemi", 150);
        }
    }
}
