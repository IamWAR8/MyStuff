using System;
using System.Collections.Generic;

namespace PizzaStoreDB.Data
{
    public partial class Location
    {
        public Location()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        public int IdLocation { get; set; }
        public string LocationName { get; set; }

        public ICollection<UserInfo> UserInfo { get; set; }
    }
}
