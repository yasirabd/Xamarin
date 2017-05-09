using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Modul4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Application.Current.Properties["id"] = "22002321";
            MainPage = new NavigationPage(new NavigationPage1());
            //MainPage = new NavigationPage(new ModalPage());
            //MainPage = new Modul4.PopUpMainPage();
            //MainPage = new Modul4.MainPage();
            //MainPage = new TabbedPageDemo();
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
