using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

namespace list
{
    internal class AddressBook
    {
        public List<Person> persons=new List<Person>();
        public AddressBook()
        {
            string jsonContent = File.ReadAllText(@"D:\BRIDGELABZVS\snake and ladder\list\adress.json");
            if (jsonContent.Length > 0)
            {
                persons = JsonConvert.DeserializeObject<List<Person>>(jsonContent);
            }
            else
            {
                persons = new List<Person>();
            }
        }
        public void Display()
        {
            Console.WriteLine("welcome to address book");
            foreach(Person person in persons)
            {
                Console.WriteLine(person.Result());
                Console.WriteLine("\n");
            }
            
        }
        public void AddPerson(Person p)
        {
            persons.Add(p);
            string jsonData=JsonConvert.SerializeObject(persons);
            File.WriteAllText(@"D:\BRIDGELABZVS\snake and ladder\list\adress.json", jsonData);
        }
        public void RemovePerson(string Name)
        {
            Person person = null;
            foreach(Person p in persons)
            {
                if(p.Name == Name)
                {
                    person = p;
                }
            }
            persons.Remove(person);
            string jsonData=JsonConvert.SerializeObject(persons);
            File.WriteAllText(@"D:\BRIDGELABZVS\snake and ladder\list\adress.json", jsonData);

        }
        public void Edit(string Name)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].Name == Name)
                {
                    Console.WriteLine("enter your name");
                    persons[i].Name =Console.ReadLine();
                    Console.WriteLine("enter your city ");
                    persons[i].City = Console.ReadLine();
                    Console.WriteLine("enter your phone number");
                    persons[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("enter your postal code");
                    persons[i].PostalCode = long.Parse(Console.ReadLine());

                }
            }
            string jsonData = JsonConvert.SerializeObject(persons);
            File.WriteAllText(@"D:\BRIDGELABZVS\snake and ladder\list\adress.json", jsonData);
        }
    }
}
