using Economick_Software.App;
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
    public partial class Inicio : Form
    {
        private readonly EconomikContext context;
        public Inicio(EconomikContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Controller.ChangeForm<Form1>(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
