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
    public partial class Form3 : Form
    {
        private readonly EconomikContext context;
        public Form3(EconomikContext context)
        {
            InitializeComponent();

            this.context = context;
        }
    }
}
