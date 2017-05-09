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
    public partial class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            InitializeComponent();
            BindingContext = new ListViewImageCellViewModel();
        }

        public class ListViewImageCellViewModel : BindableObject
        {
            private List<ListItem> listItems;
            public List<ListItem> ListItems
            {
                get { return listItems; }
                set
                {
                    listItems = value;
                    OnPropertyChanged("ListItems");
                }
            }

            public ListViewImageCellViewModel()
            {
                listItems = new List<ListItem>
                {
                    new ListItem { Source="cat.jpg", Title="Kucing", Subtitle="Meow meow meow", Description="Kucing suka meow meow meow" },
                    new ListItem { Source="cow.jpg", Title="Sapi", Subtitle="Moo moo moo", Description="Sapi suka moo moo moo" },
                    new ListItem { Source="harambe.jpg", Title="Harambe", Subtitle="Di*ks out for harambe", Description="Harambe sudah mati :(" },
                    new ListItem { Source="lion.jpg", Title="Singa", Subtitle="Aum aum aum", Description="Singa suka ngaum ngaum ngaum"},
                    new ListItem { Source="monkey.jpg", Title="Monyet", Subtitle="Huhuhaha huhuhaha huhuhaha", Description="Monyet suka kamu huhuhaha huhuhaha huhuhaha"}
                };
            }
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;

            await Navigation.PushAsync(new DetailAnimalPage(item));
            ((ListView)sender).SelectedItem = null;
        }
    }
}
