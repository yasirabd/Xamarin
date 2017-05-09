using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Catalog_Movie.Data;
using Catalog_Movie.Views;

namespace Catalog_Movie
{
    public class App : Application
    {
        public static MovieItemManager MovieManager { get; private set; }

        public App()
        {
            MovieManager = new MovieItemManager(new RestService());
            MainPage = new NavigationPage(new MovieListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
