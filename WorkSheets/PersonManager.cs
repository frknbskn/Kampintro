using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets
{
    class PersonManager
    {
        List<Person> persons = new List<Person>();

        public void Add(Person person)
        {
            persons.Add(person);
            Console.WriteLine(person.Name);
        }
        public void List()
        {
            foreach (var customer in persons)
            {
                Console.WriteLine(customer.Id+" "+customer.Name+" " +customer.Surname);
            }     
            }
    }
}
