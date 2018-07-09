using PizzaLibrary.Library.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Interfaces
{
   public  interface IUser
    {
        string FirstName { get; set; }
         string UserName { get; set; }
         string LastName { get; set; } 
         int Location { get; set; }
   
    }

}

