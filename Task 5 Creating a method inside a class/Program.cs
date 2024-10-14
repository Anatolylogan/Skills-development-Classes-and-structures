namespace Task_5_Creating_a_method_inside_a_class
{
    class Program
    {
        static void Main(string[] args)
        {
            User User1 = new User();
            User1.Name = "Толя";
            User1.Age = 22;
            User1.DisplayInfo();
        }
    }
}