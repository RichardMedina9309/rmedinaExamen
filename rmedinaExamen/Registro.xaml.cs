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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;

        }

        private void btnCalcularPaMen_Clicked(object sender, EventArgs e)
        {
            double preciocurso = 3000;
            double abono = Convert.ToDouble(txtAbonoInicial.Text);

            double suma = preciocurso - abono;
            double cuotaSinInteres = suma / 3;

            double interes = preciocurso * 0.5;
            double interesTotal = interes / 100;

            double pagoMensual = cuotaSinInteres + interesTotal;
            txtPagoMensual.Text = pagoMensual.ToString("N2");
        }

        private void btnLimpiarPaMen_Clicked(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtAbonoInicial.Text = "";
            txtPagoMensual.Text = "";
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string usuario1 = txtUsuario.Text;
            double abono = Convert.ToDouble(txtAbonoInicial.Text);
            double pagoMensual = Convert.ToDouble(txtPagoMensual.Text);

            double pagoTresMeses = pagoMensual * 3;
            double pagoTotal = abono + pagoTresMeses;
            string paTotal = Convert.ToString(pagoTotal);

            Navigation.PushAsync(new Resumen(nombre, paTotal, usuario1));
        }

        private void txtAbonoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double abonoIni = Convert.ToDouble(txtAbonoInicial.Text);
                if(abonoIni > 0 && abonoIni > 3000) 
                {
                    DisplayAlert("Mensaje", "Números entre 0 y 3000", "Cerrar");
                    txtAbonoInicial.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }
    }
}