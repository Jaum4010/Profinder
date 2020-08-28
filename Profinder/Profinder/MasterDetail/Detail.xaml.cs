using Profinder.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profinder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
        }

        private async void BtnFiltro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Filtro());

        }

        private async void BtnFavorito_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Favoritos());
        }

        private async void BtnPesquisa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pesquisa());
        }
    }
}