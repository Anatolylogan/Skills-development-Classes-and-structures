namespace MyLibary
{
    public class User
    {
        private string name;
        private int age = 30;
        public int Age
        {
            get { return age; }
        }
        public User(int age)
        {
            this.age = age;
        }
        public Address address;

        public User()
        {
            name = "Неизвстно";
        }

        public User(string n, int a)
        {
            name = n;
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
