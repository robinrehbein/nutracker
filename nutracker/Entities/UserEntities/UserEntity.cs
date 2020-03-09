using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nutracker.Entities.UserEntities
{
    public class UserEntity
    {
        public long id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public DateTime birthday { get; set; }

        public UserInfo userInfo { get; set; }
    }
}
