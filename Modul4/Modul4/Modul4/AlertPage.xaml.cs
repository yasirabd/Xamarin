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
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }
        async void OnAlertSimpleClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }
        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        }
    }
}
