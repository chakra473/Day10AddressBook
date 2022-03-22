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

            while (true)
            {
               
                Person person = new Person();
                Console.WriteLine("press:R to remove the contact \npress:E to edit the contact \npress:A to add the contact \npress:D to display the details ");
                char c = char.Parse(Console.ReadLine());
                if ((c == 'R') || (c == 'r'))
                {
                    Console.WriteLine("enter name to delete");
                    string dname = Console.ReadLine();
                    person.Name = dname;
                    addressBook.RemovePerson(dname);
                }
                else if ((c=='A') || (c=='a'))
                {
                    Console.WriteLine("enter number of contacts you want to add");
                    int num=int.Parse(Console.ReadLine());
                    while (num > 0)
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
                        addressBook.Display();
                        num--;
                    }
                }
                else if((c=='D')||(c=='d'))
                {
                  addressBook.Display();
                }
                else if((c=='E')||(c=='e'))
                {
                    Console.WriteLine("enter name to edit");
                    string ename=Console.ReadLine();
                    addressBook.Edit(ename);
                }
                else
                {
                    break;
                }
            }




        }
    }
}
