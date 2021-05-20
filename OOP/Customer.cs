using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        // Automatic Property
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }

        // Constructor
        public Customer (double purchases, string name, int id)
        {
            // assign value to Automatic Property
            // 
            TotalPurchases = purchases;
            Name = name;
            CustomerId = id;
        }

        // Method
        public string GetContactInfo()
        {
            return "Contact Information.";
        } 
    }
}
