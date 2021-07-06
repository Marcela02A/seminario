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
    public partial class Recuperar : Form

    {
        private readonly EconomikContext context;
        public Recuperar(EconomikContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (context.Users.Any(x => x.Correo == campo_recuperar.Text))
                {

            }
        }
    }
}
