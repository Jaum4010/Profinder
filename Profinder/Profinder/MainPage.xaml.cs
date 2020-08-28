using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Profinder
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            App.MasterDetail = this;
        }



    }
}
