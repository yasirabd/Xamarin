using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modul3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();
            List<string> items = new List<string> { "First", "Second", "Third" };
            listView.ItemsSource = items;

            //untuk mengambil nilai item ketika diklik pada baris 
            listView.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("Tapped", e.Item.ToString() + " was selected", "OK");
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
