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
    public partial class ModalSecondPage : ContentPage
    {
        public ModalSecondPage()
        {
            InitializeComponent();
        }

        protected async void Navigate(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
