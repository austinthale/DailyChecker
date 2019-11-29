using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyChecker.Models
{
    public class Token
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string AccessToken { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ExpireIn { get; set; }

        public Token() { }
    }
}
