using System;
using System.Collections.Generic;

namespace PizzaStoreDB.Data
{
    public partial class Orders
    {
        public int IdOrder { get; set; }
        public int LocationIdLocation { get; set; }
        public int IdUser { get; set; }
        public string LocationUser { get; set; }
        public int IdLocation { get; set; }
    }
}
