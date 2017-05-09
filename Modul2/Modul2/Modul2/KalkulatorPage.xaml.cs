using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modul2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KalkulatorPage : ContentPage
    {
        public KalkulatorPage()
        {
            InitializeComponent();

            btnTambah.Clicked += Btn_Clicked;
            btnKurang.Clicked += Btn_Clicked;
            btnKali.Clicked += Btn_Clicked;
            btnBagi.Clicked += Btn_Clicked;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            double hasil = 0;
            var myBtn = (Button)sender;
            switch (myBtn.Text)
            {
                case "Tambah":
                    hasil = Convert.ToDouble(entryBil1.Text) + Convert.ToDouble(entryBil2.Text);
                    break;
                case "Kurang":
                    hasil = Convert.ToDouble(entryBil1.Text) - Convert.ToDouble(entryBil2.Text);
                    break;
                case "Kali":
                    hasil = Convert.ToDouble(entryBil1.Text) * Convert.ToDouble(entryBil2.Text);
                    break;
                case "Bagi":
                    hasil = Convert.ToDouble(entryBil1.Text) / Convert.ToDouble(entryBil2.Text);
                    break;
            }
            entryHasil.Text = hasil.ToString();
        }
    }
}
