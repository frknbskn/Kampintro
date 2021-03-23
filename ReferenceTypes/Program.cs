using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Furkan";
            person2 = person1;
            person1.FirstName = "Eymen"; //person2 de "Eymen" oldu
             
            Customer customer = new Customer();
            Employee employee = new Employee();

        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee:Person
        {
            public string EmployeeNumber { get; set; }
        }
    }
}
