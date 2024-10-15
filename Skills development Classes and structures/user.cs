namespace Skills_development_Classes_and_structures;
using Skills_development_Classes_and_structures;
using System.Security.Cryptography.X509Certificates;
class User
{
    public string Name;
    public int Age;
    public Address address;

    public User()
    {
        Name = "Неизвстно";
        Age = 1;
    }

    public User(string n, int a)
    {
        Name = n;
        Age = a;
    }

    public void Print() => Console.WriteLine($"Имя:{Name} Возраст:{Age} {address}");
    public void DisplayInfo()
    {
        string messege = $"Имя:{Name} Возраст:{Age}";
        Console.WriteLine(messege);
    }
}