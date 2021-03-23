using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesSheets
{
    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }  // = set, .Id get
        private string _firstName;
        public string FirstName { 
            get
            {
                return "Mr." + _firstName;
            } 
            set
            {
                _firstName = value;
            } 
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
