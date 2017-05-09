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
    public partial class ShowEmployee : ContentPage
    {
        Employee mSelEmployee;
        public ShowEmployee(Employee aSelectedEmp)
        {
            InitializeComponent();
            mSelEmployee = aSelectedEmp;
            BindingContext = mSelEmployee;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditEmployee(mSelEmployee));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Konfirmasi", "Apakah anda yakin untuk mendelete data ?", "Yes", "No");
            if (accepted)
            {
                App.DBUtils.DeleteEmployee(mSelEmployee);
            }
            await Navigation.PushAsync(new ManageEmployee());
        }
    }
}
