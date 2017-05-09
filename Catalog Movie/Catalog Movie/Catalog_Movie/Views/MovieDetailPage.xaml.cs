using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Catalog_Movie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailPage : ContentPage
    {
        public MovieDetailPage(Movie a)
        {
            InitializeComponent();

            Movie item = (Movie)a;
            titleMovie.Text = item.Title;
            imageMovie.Source = item.ImageUrl;
            descriptionMovie.Text = item.Description;

            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}
