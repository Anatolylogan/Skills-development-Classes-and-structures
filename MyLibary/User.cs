namespace MyLibary
{
    public class User
    {
        private string Name;
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
        public string GetName()
        {
            return Name;
        }
    }
}
