using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileAzure
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TambahBarangPage : ContentPage
    {
        private BarangManager _barangManager = new BarangManager();
        private bool _isNew = false;
        public TambahBarangPage()
        {
            InitializeComponent();
        }

        private void ClearAll()
        {
            foreach (var ctr in gvBarang.Children)
            {
                if (ctr is Entry)
                {
                    var item = ctr as Entry;
                    item.Text = string.Empty;
                }
            }
        }

        public TambahBarangPage(bool isNew)
        {
            InitializeComponent();
            _isNew = isNew;
            if (_isNew)
            {
                txtKodeBarang.Focus();
            }
        }

        private async void BtnSave_OnClicked(object sender, EventArgs e)
        {
            if (_isNew)
            {
                var barang = new Barang()
                {
                    KodeBarang = txtKodeBarang.Text,
                    NamaBarang = txtNamaBarang.Text,
                    Stok = Convert.ToInt32(txtStok.Text),
                    HargaBeli = Convert.ToDecimal(txtHargaBeli.Text),
                    HargaJual = Convert.ToDecimal(txtHargaJual.Text)
                };
                await _barangManager.SaveTaskAsync(barang);
                ClearAll();
                await DisplayAlert("Keterangan", "Data Barang berhasil ditambah !", "OK");
            }
            else
            {
                var barang = (Barang)this.BindingContext;
                await _barangManager.SaveTaskAsync(barang);
                await DisplayAlert("Keterangan", "Data Barang berhasil diupdate !", "OK");
            }
        }
    }
}