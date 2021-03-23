using System;

namespace ClassesSheets
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Furkan";
            customer1.LastName = "BAŞKAN";
            customer1.City = "Sakarya";

            Customer customer2 = new Customer { Id = 2, FirstName = "Eymen", LastName = "BAŞKAN", City = "Zonguldak" };

            Customer customer3 = new Customer ( 3, "Enes", "BAŞKAN", "Düzce" );

            Console.WriteLine(customer3.FirstName);
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }

    }
}
