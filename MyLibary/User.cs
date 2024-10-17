namespace MyLibary
{
    public class User
    {
        public Address address;
        private string name;
        private int age;
        private static int userCount = 0;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
            userCount++;
        }

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public static int UserCount
        {
            get { return userCount; }
        }

        public void UpdateInfo(string newName)
        {

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
