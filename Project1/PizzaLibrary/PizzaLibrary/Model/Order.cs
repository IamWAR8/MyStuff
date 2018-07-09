using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Library.Model
{
    public class Inventory : IInventory
    {

        public int Id { get; set; }
        public string Pname { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Location  { get; set; }
    }
}