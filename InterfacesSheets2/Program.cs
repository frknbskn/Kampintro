using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSheets2
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterFaces();


            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]{
                new SQLServerCustomerDal(),new OracleCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); 
            }

            Console.ReadLine();



        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SQLServerCustomerDal());
        }

        private static void InterFaces()
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "BAŞKAN"
            };
            Student student1 = new Student(2, "Eymen", "BAŞKAN");
            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);
            personManager.Add(student1);
        }

        interface IPerson
        {
             int Id { get; set; }
             string FirstName { get; set; }
             string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Student : IPerson
        {
            public Student()
            {

            }
            public Student(int id,string firstName,string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;

            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Depertmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
