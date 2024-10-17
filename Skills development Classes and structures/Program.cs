using Skills_development_Classes_and_structures;
using System.Net.Sockets;
using MyLibary;
namespace Skills_development_Classes_and_structures
{
    class Program
    {
        Address address = new ("Nov", "Top");

        static void Main(string[] args)
        {
            User User1 = new User("Анатолий",22);
            Console.WriteLine($"Имя {User1.GetName()} Возраст {User1.Age}");
            Console.WriteLine($"Имя пользователя:{User1.Name}, Возраст {User1.Age}");

            User1.UpdateInfo("Александр");
            Console.WriteLine($"Имя пользователя:{User1.Name}, Возраст {User1.Age}");

            User1.UpdateInfo("Пётр", 35);
            Console.WriteLine($"Имя пользователя:{User1.Name}, Возраст {User1.Age}");
        }

    }
}
