using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Person
    {
        public string Name;
        public string City;
        public long PhoneNumber;
        public long PostalCode;
       
       public string Result()
        {
            return "Name: " + Name + "\n" + "City: " + City + "\n" + "PhoneNumber: " + PhoneNumber + "\n" + "PostalCode: " + PostalCode;
           
        }
    }
}
