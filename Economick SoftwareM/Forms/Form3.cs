using Economick_Software.App;
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
        public Form3()
        {
            InitializeComponent();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            Controller.ChangeForm(this, sender as Economick_Software.Forms.Controls.Menu);
        }
    }
}
