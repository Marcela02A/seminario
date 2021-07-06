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
    public partial class Registro : Form
    {
        private readonly EconomikContext context;
        public Registro(EconomikContext context)
        {
            InitializeComponent();
            this.context = context;
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
            String ciudad, tipod,rol;
            ciudad = Convert.ToString(combobox_ciudad.SelectedItem);
            tipod = Convert.ToString(combobox_documento);
            rol = Convert.ToString(combobox_rol);

            context.Users.Add(new UserInfo
            {
                Nombres = campo_nombre.Text,
                Apellidos = campo_apellido.Text,
                Numero_documento = campo_documento.Text,
                Correo = campo_correo.Text,
                Direccion = campo_direccion.Text,
                Contrasena = campo_contraseña.Text,
                Ciudad = new Ciudad
                {
                    Nombres=ciudad,
                },
                Rol=new RolInfo
                {
                    descripcion= rol,
                },
                Tipo_documento= new TipoDocumento
                {
                    Descripcion=tipod,
                }
          

            });
            context.SaveChanges();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
