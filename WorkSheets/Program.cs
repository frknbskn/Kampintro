using System;

namespace WorkSheets
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "Furkan";

            person2 = person1;
            person1.Name = "Eymen";
            Console.WriteLine(person2.Name);

            Customer customer1 = new Customer();
            customer1.Name = "Eymen";
            customer1.CreditCardNumber = "123456";



            Employee employee1 = new Employee();
            employee1.Name = "Jack";

            Person person3 = customer1;
            Console.WriteLine(customer1.Name);          //BASE CLASS=PERSON
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee1);

            personManager.List();
            personManager.Add(customer1);
            personManager.List();




        }
    }
}
