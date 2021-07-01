using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecomarck2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }



        public bool vacio; 
        private void validarCampos(Form formulario)
        {
            foreach (Control VControls in formulario.Controls) 
            {
                if (VControls is TextBox & VControls.Text == String.Empty) 
                {
                    vacio = false; 
                } else if (VControls is ComboBox & VControls.Text == String.Empty)
                {
                    vacio = false;
                } else if (check_terminos.Checked == false)
                {
                    vacio = false;
                }
            }
            if (vacio == false)
            {
                MessageBox.Show("No debe dejar ningun campo vacio");
            }
            else
            {
                MessageBox.Show("Su registro fue exitoso");
            }
               
                vacio = true; 
        }




        private void Button1_Click(object sender, EventArgs e)
        {
            validarCampos(this);
        }
    }
}
