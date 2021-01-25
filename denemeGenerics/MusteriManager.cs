using System;
using System.Collections.Generic;
using System.Text;

namespace denemeGenerics
{
    class MusteriManager
    {
        List<Musteri> customers = new List<Musteri>();

        public void Add(Musteri musteri)
        {
            customers.Add(musteri);
            Console.WriteLine(musteri.FirstName+musteri.LastName+" eklendi.");

        }
        public void List()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id+customer.FirstName+customer.LastName+customer.City);
            }
        }
        public void Remove(Musteri item)
        {
            customers.Remove(item);
            Console.WriteLine(item.FirstName+" silindi.");
        }

    }
}
