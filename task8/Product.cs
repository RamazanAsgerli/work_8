using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Product
    {
        private byte _price;
        private byte _count;
        public string No;
        public string Name;

        public byte Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    value = _price;
                }
                else
                {
                    Console.WriteLine("duzgun daxil edin");
                }
            }
        }

        public byte Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("duzgun daxil edin");
                }
            }
        }

        public Product(string no, string name)
        {
            No = no;
            Name = name;
        }
    }
}
