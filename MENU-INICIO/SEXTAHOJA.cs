﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPRO__SANTIAGO_MINES_PROJECT_
{
    public partial class SEXTAHOJA : Form
    {
        public SEXTAHOJA()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form llamado8 = new CUARTAHOJA();
            llamado8.ShowDialog();  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form llamado9 = new CUARTAHOJA();
            llamado9.ShowDialog();

        }
    }
}
