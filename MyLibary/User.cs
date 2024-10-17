namespace MyLibary
{
    public class User
    {
        public Address address;
        private string name;
        private int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }

        public void UpdateInfo(string newName)
        {
            name = newName;
            Console.WriteLine($"Имя обновленно");
        }
        public void UpdateInfo(string newName, int newAge)
        {
            name = newName;
            age = newAge;
            Console.WriteLine($"Имя и возраст обнавлены");
        }

        public void Print() => Console.WriteLine($"Имя:{name} Возраст:{Age} {address}");
        public void DisplayInfo()
        {
            string messege = $"Имя:{name} Возраст:{Age}";
            Console.WriteLine(messege);
        }
        public string GetName()
        {
            return name;
        }
    }
}
