using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tugas2Dicoding.Models;

namespace Tugas2Dicoding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailAnimalPage : ContentPage
    {
        public DetailAnimalPage(ListItem a)
        {
            InitializeComponent();

            ListItem item = (ListItem)a;
            titleAnimal.Text = item.Title;
            imageAnimal.Source = item.Source;
            descriptionAnimal.Text = item.Description;

            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}
