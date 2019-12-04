using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChecker.Models
{
    public class Settings
    {
        [PrimaryKey]
        public int ID { get; set; }
        public bool switch1 { get; set; }
        public bool switch2 { get; set; }
    }
}
