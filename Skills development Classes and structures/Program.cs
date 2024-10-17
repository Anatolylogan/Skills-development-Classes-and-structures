using Skills_development_Classes_and_structures;
using System.Net.Sockets;
using MyLibary;
using System;
namespace Skills_development_Classes_and_structures
{
    class Program
    {
        Address address = new ("Nov", "Top");

        static void Main(string[] args)
        {
            User user = new User("Анатолий",22);
            Console.WriteLine($"Имя {user.GetName()} Возраст {user.Age}");
            Console.WriteLine($"Кол-во пользователей: {User.UserCount}");
            
            User User1 = new User("Николай", 25);
            Console.WriteLine($"Имя пользователя:{User1.Name}, Возраст {User1.Age}");
            Console.WriteLine($"Кол-во пользователей: {User.UserCount}");

            User User2 = new User("Александр", 0);
            user.UpdateInfo("Александр");
            Console.WriteLine($"Имя пользователя:{User2.Name}, Возраст {User2.Age}");
            Console.WriteLine($"Кол-во пользователей: {User.UserCount}");

            User User3 = new User("Пётр", 35);
            user.UpdateInfo("Пётр", 35);
            Console.WriteLine($"Имя пользователя:{User3.Name}, Возраст {User3.Age}");
            Console.WriteLine($"Кол-во пользователей: {User.UserCount}");
        }

    }
}
