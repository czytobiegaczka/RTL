﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTL
{
    public partial class frmMessageOK : Form
    {
        public frmMessageOK()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
    }
}
