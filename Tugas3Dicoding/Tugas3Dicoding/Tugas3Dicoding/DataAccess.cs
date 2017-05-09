using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Attributes;
using Xamarin.Forms;

namespace Tugas3Dicoding
{
    public class DataAccess
    {
        SQLiteConnection dbConn;

        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLIte>().GetConnection();
            dbConn.CreateTable<Storage>();
        }

        public List<Storage> GetAllStorages()
        {
            return dbConn.Query<Storage>("Select * From [Storage]");
        }

        public int SaveStorage(Storage aStorage)
        {
            return dbConn.Insert(aStorage);
        }

        public int DeleteStorage(Storage aStorage)
        {
            return dbConn.Delete(aStorage);
        }

        public int EditStorage(Storage aStorage)
        {
            return dbConn.Update(aStorage);
        }

        public int GetAllStorageAmounts()
        {
            //SQLiteCommand command;
            string query = "SELECT SUM(amountTransaksi) FROM [Storage]";
            var command = dbConn.CreateCommand(query);
            int hasil = command.ExecuteScalar<Int32>();
            return hasil;
        }
    }
}
