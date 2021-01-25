using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Furkan",Lastname="BAŞKAN",City="Sakarya" };

            Customer customer2 = new Customer(2,"Eymen","BAŞKAN","Zonguldak");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Gigo";
            customer3.Lastname = "Fişek";
            customer3.City = "İstanbul";


        }
    }

    class Customer
    {   //default constructor
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            Lastname = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

    }
}
