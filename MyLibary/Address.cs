using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibary
{
    public struct Address
    {
        public string City;
        public string Street;

        public Address(string c, string s)
        {
            City = c;
            Street = s;
        }

        public void Print() => Console.WriteLine($"Адресс:{City},{Street}");
    }
}