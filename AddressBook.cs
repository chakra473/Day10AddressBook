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
            if(jsonContent.Length>0)
            {
                persons=JsonConvert.DeserializeObject<List<Person>>(jsonContent);
            }
            else
            {
                persons=new List<Person>();
            }
        }
        public void Display()
        {
            Console.WriteLine("welcome to address book");
            foreach(Person person in persons)
            {
                Console.WriteLine(person.Result());
            }
        }
        public void AddPerson(Person p)
        {
            persons.Add(p);
            string jsonData=JsonConvert.SerializeObject(persons);
            File.WriteAllText(@"D:\BRIDGELABZVS\snake and ladder\list\adress.json", jsonData);
        }
    }
}
