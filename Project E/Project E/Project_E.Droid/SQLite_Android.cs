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
using Project_E.Interfaces;
using System.IO;
using Project_E.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Android))]

namespace Project_E.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}