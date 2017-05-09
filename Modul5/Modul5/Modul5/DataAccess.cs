using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;

namespace Modul5
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLIte>().GetConnection();
            dbConn.CreateTable<Employee>();
        }

        public List<Employee> GetAllEmployees()
        {
            return dbConn.Query<Employee>("Select * From [Employee]");
        }

        public int SaveEmployee(Employee aEmployee)
        {
            return dbConn.Insert(aEmployee);
        }

        public int DeleteEmployee(Employee aEmployee)
        {
            return dbConn.Delete(aEmployee);
        }

        public int EditEmployee(Employee aEmployee)
        {
            return dbConn.Update(aEmployee);
        }
    }
}
