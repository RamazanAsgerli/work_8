using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Book:Product
    {
        public string Genre;

        public Book(string no, string name, string genre, byte price, byte count) : base(no, name)
        {
            Genre = genre;
            Price = price;
            Count = count;
        }

        public void ShowInfo()
        {
            Console.WriteLine(GetFullData());
        }

        public string GetFullData()
        {
            return $"No: {No}, Name: {Name}, Genre: {Genre}, Price: {Price}, Count: {Count}";
        }
    }
}
