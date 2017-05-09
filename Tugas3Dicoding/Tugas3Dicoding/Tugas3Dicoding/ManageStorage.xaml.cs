using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tugas3Dicoding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageStorage : ContentPage
    {
        public ManageStorage()
        {
            InitializeComponent();
            var vList = App.DBUtils.GetAllStorages();
            string hasil = App.DBUtils.GetAllStorageAmounts().ToString();
            TotalAmount.Text = hasil;
            lstData.ItemsSource = vList;

        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var vSelUser = (Storage)e.SelectedItem;
            Navigation.PushAsync(new ShowStorage(vSelUser));
        }

        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddStorage());
        }

    }
}
