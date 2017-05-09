using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using Tugas3Dicoding.Droid;
using System.IO;
using Tugas3Dicoding;

[assembly: Dependency(typeof(SqliteService))]
namespace Tugas3Dicoding.Droid
{
    public class SqliteService : ISQLIte
    {
        public SqliteService() { }
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Storage.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}