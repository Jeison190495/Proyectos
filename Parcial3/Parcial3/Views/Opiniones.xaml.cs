using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opiniones : ContentPage
    {
        public Opiniones()
        {
            InitializeComponent();
        }

        private async void Guardar_clicked(object sender, EventArgs e)
        {
           try
            {
                var item = new ComentariosX
                {
                    Name = Nombres.Text,
                    Email = Emailss.Text,
                    Description = descipcion.Text,
                };
                var result = await App.Context.InsertItemAsyn(item);
                if (result == 1)
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "No se puede guardar tarea", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}