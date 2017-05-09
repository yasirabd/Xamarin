using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Tugas3Dicoding
{
    public partial class App : Application
    {
        private static DataAccess dbUtils;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ManageStorage());
        }

        public static DataAccess DBUtils
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DataAccess();
                }
                return dbUtils;
            }
        }
    }
}
