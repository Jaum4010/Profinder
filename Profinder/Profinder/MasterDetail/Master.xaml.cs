using Profinder.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Profinder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }
       
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await App.NavigationMasterDetail(new Favoritos());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await App.NavigationMasterDetail(new Login());
        }
    }

}