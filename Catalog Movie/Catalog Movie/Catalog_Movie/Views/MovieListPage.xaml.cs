using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Catalog_Movie.Models;

namespace Catalog_Movie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieListPage : ContentPage
    {
        public MovieListPage()
        {
            InitializeComponent();
            listView.ItemsSource = Movie.All;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await App.MovieManager.GetTasksAsync();
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Movie item = (Movie)e.Item;

            await Navigation.PushAsync(new MovieDetailPage(item));
            ((ListView)sender).SelectedItem = null;
        }
    }
}
