using System;
using System.Collections.Generic;
using Newtonsoft;
namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.Display();
            Person person = new Person();
            Console.WriteLine("enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("enter your city ");
            string city = Console.ReadLine();
            Console.WriteLine("enter your phone number");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine("enter your postal code");
            long postalCode=long.Parse(Console.ReadLine());
            person.Name = name;
            person.City = city;
            person.PhoneNumber = phoneNumber;
            person.PostalCode = postalCode;
            addressBook.AddPerson(person);
            addressBook.Display();



          
        }
    }
}
