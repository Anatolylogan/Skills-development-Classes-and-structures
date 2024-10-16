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
            User User1 = new User();
            User1.Name = "Толя";
            User1.Age = 22;
            User1.DisplayInfo();
        }
    }
}
