using Economick_Software.Data;
using Economick_Software.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Economick_Software.Forms
{
    public partial class Clientes : Form
    {
        private readonly EconomikContext context;

        public Clientes(EconomikContext context)
        {
            this.context = context;
            InitializeComponent();
            LoadUserDataGrid();
        }

        private void LoadUserDataGrid()
        {
            dataGridView1.DataSource = context.Users.ToList();
        }
    }
}