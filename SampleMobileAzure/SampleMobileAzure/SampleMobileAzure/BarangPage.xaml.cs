using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileAzure
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarangPage : ContentPage
    {
        private BarangManager _barangManager = new BarangManager();
        public BarangPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshItems(true);
        }

        private async Task RefreshItems(bool showActivityIndicator)
        {
            using (var scope = new ActivityIndicatorScope(syncIndicator, showActivityIndicator))
            {
                listViewBarang.ItemsSource = await _barangManager.GetBarangAsync();
            }
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            TambahBarangPage tambahPage = new TambahBarangPage();

            Barang item = (Barang)e.Item;
            tambahPage.BindingContext = item;
            ((ListView)sender).SelectedItem = null;
            await Navigation.PushAsync(tambahPage);
        }

        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            TambahBarangPage tambahPage = new TambahBarangPage(true);
            await Navigation.PushAsync(tambahPage);
        }

        private async void ListViewBarang_OnRefreshing(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            Exception error = null;
            try
            {
                await RefreshItems(false);
            }
            catch (Exception ex)
            {
                error = ex;
            }
            finally
            {
                list.EndRefresh();
            }

            if (error != null)
            {
                await DisplayAlert("Refresh Error !", "Couldn't refresh data (" + error.Message + ")", "OK");
            }
        }
    }
}
