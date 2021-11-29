using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingComponentsApp
{
    class Book
    {
        readonly public int Id;
        public string Name;
        public string Description;
        public string Genre;
        public int Price;
        
        public Book(int id,string name, string description, string genre, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Genre = genre;
            Price = price;
        }

    }
}
