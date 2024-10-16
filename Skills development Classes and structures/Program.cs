using Skills_development_Classes_and_structures;
using System.Net.Sockets;
using MyLibary;
namespace Skills_development_Classes_and_structures
{
    class Program
    {
        User nez = new();
        User tol = new("Tolya", 22);
        Address address = new ("Nov", "Top");
     

        static void Main(string[] args)
        {
            User User1 = new User("Анатолий",22);
            Console.WriteLine($"Имя {User1.GetName()} Возраст {User1.Age}");
        }
    }
}
