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
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2(string param)
        {
            InitializeComponent();

            lblParam.Text = "Nama anda : " + param + "id " + (string)Application.Current.Properties["id"];

            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}
