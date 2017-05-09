using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modul5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManageEmployee : ContentPage
    {
        public ManageEmployee()
        {
            InitializeComponent();
            var vList = App.DBUtils.GetAllEmployees();
            lstData.ItemsSource = vList;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var vSelUser = (Employee)e.SelectedItem;
            Navigation.PushAsync(new ShowEmployee(vSelUser));
        }

        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddEmployee());
        }
    }
}
