namespace MyLibary
{
    public class User
    {
        public Address address;
        private string name;
        private int age;
        private static int userCount = 0;
        public readonly int Id;

        public User(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.Id= id;
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

            Console.WriteLine($"ИМЯ ПОЛЬЗОВАТЕЛЯ ОБНОВЛЕННО:");
        }
        public void UpdateInfo(string newName, int newAge)
        {
            name = newName;
            age = newAge;
            Console.WriteLine($"ИМЯ И ВОЗРАСТ ПОЛЬЗОВАТЕЛЯ ОБНОВЛЕННЫ: ");
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
