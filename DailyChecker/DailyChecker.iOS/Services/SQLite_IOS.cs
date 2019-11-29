using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DailyChecker.iOS.Services;
using DailyChecker.Services;
using Foundation;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace DailyChecker.iOS.Services
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }
}