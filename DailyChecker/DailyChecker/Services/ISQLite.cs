using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChecker.Services
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
