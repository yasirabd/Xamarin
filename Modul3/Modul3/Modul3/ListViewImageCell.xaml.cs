using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Modul3.Models;

namespace Modul3
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
            public ListViewImageCellViewModel()
            {
                listItems = new List<ListItem>
                {
                    new ListItem { Source="first.png", Title="Mystic", Description="Mystic team blue badge" },
                    new ListItem { Source="second.png", Title="Instinct",Description="Instinct team yellow badge" },
                    new ListItem { Source="third.png", Title="Valor",Description="Valor team red badge" }
                };
            }

            public List<ListItem> ListItems
            {
                get { return listItems; }
                set
                {
                    listItems = value;
                    OnPropertyChanged("ListItems");
                }
            }
        }
        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title.ToString() + " was selected", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}
