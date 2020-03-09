using System;

namespace nutracker.Models.User
{
    public class User
    {
        public string firstname { get; set; }

        public string lastname { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public DateTime birthday { get; set; }

        public UserInfo userInfo { get; set; }
    }
}
