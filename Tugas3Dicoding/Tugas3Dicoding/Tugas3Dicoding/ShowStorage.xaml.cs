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
    public partial class ShowStorage : ContentPage
    {
        Storage mSelfStorage;
        public ShowStorage(Storage aSelectedSto)
        {
            InitializeComponent();
            mSelfStorage = aSelectedSto;
            BindingContext = mSelfStorage;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditStorage(mSelfStorage));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk mendelete data ?", "Yes", "No");
            if (accepted)
            {
                App.DBUtils.DeleteStorage(mSelfStorage);
            }
            await Navigation.PushAsync(new ManageStorage());
        }
    }
}
