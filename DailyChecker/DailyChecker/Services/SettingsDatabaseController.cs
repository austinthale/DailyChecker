using DailyChecker.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DailyChecker.Services
{
    public class SettingsDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;
        public SettingsDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Settings>();


        }

        public Settings GetSettings()
        {
            lock (locker)
            {
                if(database.Table<Settings>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Settings>().First();
                }
            }
        }

        public int SaveSettings(Settings settings)
        {
            lock (locker)
            {
                if (settings.ID != 0)
                {
                    database.Update(settings);
                    return settings.ID;
                }
                else
                {
                    settings.ID = 1;
                    return database.Insert(settings);
                }
            }
        }

        public int DeleteSettings(int ID)
        {
            lock (locker)
            {
                return database.Delete<Settings>(ID);
            }
        }
    }
}
