using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightweightClass
{
    public class Contact
    {
        public string Name { get; }
        public string Address { get; private set;}

        public Contact(string contactName, string contactAddress)
        {
            Name = contactName;
            Address = contactAddress;
        }      
    }

    public class Contact2
    {
        public string Name { get; private set; }
        public string Address { get; }

        public Contact2(string contactName, string contactAddress)
        {
            Name = contactName;
            Address = contactAddress;
        }
        public static Contact2 CreateContact(string name, string address)
        {
            return new Contact2(name, address);
        }

        public static Contact2 CreateContact2(string name, string address)
        {
            return new Contact2(name, address);
        }
    }
}