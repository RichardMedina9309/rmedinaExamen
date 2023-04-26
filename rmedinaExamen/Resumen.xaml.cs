using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rmedinaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string paTotal, string usuario1)
        {
            InitializeComponent();
            txtNombre1.Text = nombre;
            txtPagoTotal.Text = paTotal;
            txtUsuario.Text = usuario1;
        }
    }
}