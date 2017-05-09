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
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        protected async void Navigate(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new ModalSecondPage(), false);
        }
    }
}
