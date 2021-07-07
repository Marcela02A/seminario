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
    public partial class Clientes : Form
    {
        private readonly EconomikContext Context;
        public Clientes(EconomikContext context)
        {
            Context = context;
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            dataGridView1.DataSource = Context.Users.ToList();
        }
    }
}
