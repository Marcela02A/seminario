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

namespace Economick_Software
{
    public partial class Form1 : Form
    {
        private readonly EconomikContext context;
        public Form1(EconomikContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.ChangeForm<Recuperar>(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.ChangeForm<Registro>(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (context.Users.Any(x => x.Correo == textBox2.Text && x.Contrasena == textBox1.Text))
            {
                Controller.ChangeForm<Clientes>(this);
            }
            else
            {
                MessageBox.Show("El usuario es incorrecto");
            }

            //List<UserInfo> data = context.Users.Where(x => x.Correo == textBox2.Text && x.Contrasena == textBox1.Text).ToList();

            //if (data.Any())
            //{
            //    MessageBox.Show("El usuario existe where");
            //}

            //UserInfo datas = context.Users
            //    .Include(i => i.Rol)
            //    .Include(i => i.Tipo_documento)
            //    .Include(y => y.Ciudad)
            //    .FirstOrDefault(x => x.Correo == textBox2.Text && x.Contrasena == textBox1.Text);

            //datas.Direccion = "1234567";

            //if (datas != null)
            //{
            //    MessageBox.Show("El usuario existe FirstOrDefault");
            //}


            //context.Users.Add(new UserInfo
            //{
            //    Apellidos = "hector",
            //    Nombres = "lavo",
            //    Ciudad = new Ciudad
            //    {
            //        Nombres = "cali",
            //        Latitud = 0,
            //        Longitud = 0
            //    },
            //    Contrasena = "1234",
            //    Rol = context.RolInfo.FirstOrDefault(x => x.Id == 2),
            //    Tipo_documento = new TipoDocumento { Descripcion = "cc" },
            //    Correo = "1234"
            //});

            //context.Users.ToList().ForEach(x => x.Apellidos = "hola");

            //context.CompraProducto.Add(new CompraProducto
            //{
            //    Cantidad = 5,
            //    Compra = new Compra
            //    {
            //        Cantidad = 15,
            //        Compania = new Compania
            //        {
            //            Direccion = "Calle siempre viva",
            //            Nit = "123456",
            //            Nombres = "Hola"
            //        },
            //        Fecha = DateTime.Now
            //    },
            //    Producto = new Producto
            //    {
            //        Codigo = "10",
            //        Nombres = "Banana",
            //        precio = 9000,
            //        Stock = 20,
            //        Descripcion = "super banana"
            //    }
            //});

            //context.SaveChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
