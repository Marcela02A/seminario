﻿using Economick_Software.App;
using Economick_Software.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economick_Software.Forms
{
    public partial class Form3 : Form
    {
        private readonly EconomikContext context;
        public Form3(EconomikContext context)
        {
            InitializeComponent();

            this.context = context;
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void menu2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller.ChangeForm<Inicio>(this);
        }
    }
}
