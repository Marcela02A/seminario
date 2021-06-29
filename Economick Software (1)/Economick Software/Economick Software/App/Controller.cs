using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economick_Software.App
{
    public static class Controller
    {
        public static void ChangeForm(Form currentForm, Forms.Controls.Menu menu)
        {
            currentForm.Hide();
            switch (menu.ActiveControl.Name)
            {
                case "button1":
                    Form3 form3 = Program.ServiceProvider.GetRequiredService<Form3>();
                    form3.Closed += (s, arg) => currentForm.Close();
                    form3.Show();
                    break;
                case "button2":
                    Form4 form4 = Program.ServiceProvider.GetRequiredService<Form4>();
                    form4.Closed += (s, arg) => currentForm.Close();
                    form4.Show();
                    break;

            }
            
            
        }
    }
}
