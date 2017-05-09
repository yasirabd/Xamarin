using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modul4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();
            btnSecond.Clicked += BtnSecond_Clicked;
        }

        private async void BtnSecond_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2("Erick Kurniawan"));
        }
    }
}
