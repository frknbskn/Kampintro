using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Products
    {
        public Products()
        {

        }
        public Products(int id, string category, string name)
        {
            Id = id;
            Category = category;
            Name = name;
        }
        public int Id { get; set; }
        public string Category { get; set; }

        private string _name;
        public string Name
        {
            get
            {
                return "Product: " + _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
