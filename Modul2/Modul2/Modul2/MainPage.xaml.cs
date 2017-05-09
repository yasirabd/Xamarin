using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Modul2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnHello.Clicked += BtnHello_Clicked;
        }

        private void BtnHello_Clicked(object sender, EventArgs e)
        {
            lblDetail.Text = entryHello.Text;
        }
    }
}
