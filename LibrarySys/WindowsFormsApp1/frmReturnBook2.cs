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
    public partial class frmReturnBook2 : Form
    {
        frmReturnBook parent;

        public frmReturnBook2()
        {
            InitializeComponent();
        }

        public frmReturnBook2(frmReturnBook Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
