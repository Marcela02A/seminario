<?xml version="1.0" encoding="utf-8"?>
using Economick_Software.App;
using Economick_Software.Bussiness.Interfaces;
using Economick_Software.Data;
using Economick_Software.Data.Entities;
using Economick_Software.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economick_Software.Forms
{
    public partial class Clientes : Form
    {
        private readonly EconomikContext context;
        public Clientes(EconomikContext context)
        {
            Context = context;
            InitializeComponent();
            this.context = context;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<UserInfo> data = context.Users.ToList();
            dataGridView1.DataSource
                = data;
        }
    }
}
