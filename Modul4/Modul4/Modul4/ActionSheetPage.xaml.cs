using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modul4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActionSheetPage : ContentPage
    {
        public ActionSheetPage()
        {
            InitializeComponent();
        }
        async void OnActionSheetSimpleClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }
        async void OnActionSheetCancelDeleteClicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
        }
    }
}
