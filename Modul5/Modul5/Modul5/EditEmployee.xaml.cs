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
    public partial class EditEmployee : ContentPage
    {
        Employee mSelEmployee;
        public EditEmployee(Employee aSelectedEmp)
        {
            InitializeComponent();
            mSelEmployee = aSelectedEmp;
            BindingContext = mSelEmployee;
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            mSelEmployee.EmpName = txtEmpName.Text;
            mSelEmployee.Department = txtDepartment.Text;
            mSelEmployee.Designation = txtDesign.Text;
            mSelEmployee.Qualification = txtQualification.Text;
            App.DBUtils.EditEmployee(mSelEmployee);
            Navigation.PushAsync(new ManageEmployee());
        }
    }
}
