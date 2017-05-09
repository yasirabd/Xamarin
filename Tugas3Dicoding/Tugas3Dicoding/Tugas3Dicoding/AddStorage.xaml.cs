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
    public partial class AddStorage : ContentPage
    {
        public AddStorage()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            var vStorage = new Storage()
            {
                jenisTransaksi = txtJenisTransaksi.Text,
                amountTransaksi = Convert.ToInt32(txtAmountTransaksi.Text),
                dateTransaksi = txtDateTransaksi.Text,
                infoTransaksi = txtInfoTransaksi.Text,
                //totalTransaksi = Convert.ToInt32(txtAmountTransaksi.Text)
            };
            App.DBUtils.SaveStorage(vStorage);
            Navigation.PushAsync(new ManageStorage());
        }
    }
}
