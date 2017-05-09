using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tugas1Dicoding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnLaki.Clicked += Btn_Clicked;
            btnPerempuan.Clicked += Btn_Clicked;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            double beratIdeal = 0;
            double BMI = 0;
            string hasil = "";
            var myBtn = (Button)sender;

            BMI = Math.Ceiling(Convert.ToDouble(beratBadan.Text) / (Convert.ToDouble(tinggiBadan.Text) * Convert.ToDouble(tinggiBadan.Text) / 10000));

            switch (myBtn.Text)
            {
                case "HITUNG BERAT BADAN IDEAL LAKI-LAKI":
                    beratIdeal = (Convert.ToDouble(tinggiBadan.Text) - 100) - (0.1 * (Convert.ToDouble(tinggiBadan.Text) - 100));
                    if (BMI < 17)
                    {
                        hasil = "Kurus (< 17 Kg)";
                    }
                    else if (BMI >= 17 && BMI <= 23)
                    {
                        hasil = "Normal (17 - 23 Kg)";
                    }
                    else if (BMI > 23 && BMI <= 27)
                    {
                        hasil = "Kegemukan (23 - 27 Kg)";
                    }
                    else if (BMI > 27)
                    {
                        hasil = "Obesitas (> 27 Kg)";
                    }
                    break;
                case "HITUNG BERAT BADAN IDEAL PEREMPUAN":
                    beratIdeal = (Convert.ToDouble(tinggiBadan.Text) - 100) - (0.15 * (Convert.ToDouble(tinggiBadan.Text) - 100));
                    if (BMI < 18)
                    {
                        hasil = "Kurus (< 18 Kg)";
                    }
                    else if (BMI >= 18 && BMI <= 25)
                    {
                        hasil = "Normal (18 - 25 Kg)";
                    }
                    else if (BMI > 25 && BMI <= 27)
                    {
                        hasil = "Kegemukan (25 - 27 Kg)";
                    }
                    else if (BMI > 27)
                    {
                        hasil = "Obesitas (> 27 Kg)";
                    }
                    break;
            }

            brocha.Text = Math.Floor(beratIdeal).ToString();
            nilaiBMI.Text = BMI.ToString();
            kesimpulan.Text = hasil;
        }
    }
}
