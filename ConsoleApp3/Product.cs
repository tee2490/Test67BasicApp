using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }   
        public double Amount { get; set; }

        public Product(int Id,string Name,double Price, double Amount) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Amount = Amount;
        }
    }
}
