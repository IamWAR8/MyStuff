using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Model
{
    class User : IUser
    {

        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public int Location { get; set; } //Users will have a default location which is unique and numbered
 
    }
}

