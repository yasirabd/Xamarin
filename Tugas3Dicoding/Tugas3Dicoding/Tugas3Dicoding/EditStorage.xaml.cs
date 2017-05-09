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
    public partial class EditStorage : ContentPage
    {
        Storage mSelfStorage;
        public EditStorage(Storage aSelectedEmp)
        {
            InitializeComponent();
            mSelfStorage = aSelectedEmp;
            BindingContext = mSelfStorage;
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            mSelfStorage.jenisTransaksi = txtJenisTransaksi.Text;
            mSelfStorage.amountTransaksi = Convert.ToInt32(txtAmountTransaksi.Text);
            mSelfStorage.dateTransaksi = txtDateTransaksi.Text;
            mSelfStorage.infoTransaksi = txtInfoTransaksi.Text;
            App.DBUtils.EditStorage(mSelfStorage);
            Navigation.PushAsync(new ManageStorage());
        }
    }
}
