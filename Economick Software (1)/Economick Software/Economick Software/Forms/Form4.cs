﻿using Economick_Software.App;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economick_Software
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            Controller.ChangeForm(this, sender as Economick_Software.Forms.Controls.Menu);
        }
    }
}
