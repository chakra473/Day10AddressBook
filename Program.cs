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
           
            addressBook.Display();
            
            while (true)
            {
                Console.WriteLine("press:D to delete the contact \npress:E to edit the contact \npress:A to add the contact \npress:s to display the details ");
                char c = char.Parse(Console.ReadLine());
                if ((c == 'D') || (c == 'd'))
                {
                    Console.WriteLine("enter name to delete");
                    string dname = Console.ReadLine();
                    person.Name = dname;
                    addressBook.RemovePerson(dname);
                }
                else if ((c=='A') || (c=='a'))
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your city ");
                    string city = Console.ReadLine();
                    Console.WriteLine("enter your phone number");
                    long phoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("enter your postal code");
                    long postalCode = long.Parse(Console.ReadLine());
                    person.Name = name;
                    person.City = city;
                    person.PhoneNumber = phoneNumber;
                    person.PostalCode = postalCode;
                    addressBook.AddPerson(person);
                }
                else if((c=='S')||(c=='s'))
                {
                    addressBook.Display();
                }
                else
                {
                    break;
                }
            }




        }
    }
}
