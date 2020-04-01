using System;

namespace nutracker.Models.User
{
    public class User
    {
        public long Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public UserInfo UserInfo { get; set; }
    }
}
