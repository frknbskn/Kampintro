using System;
using System.Collections.Generic;
using System.Text;

namespace denemeGenerics
{
    class Musteri
    {
        public Musteri()
        {

        }
        public Musteri(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
