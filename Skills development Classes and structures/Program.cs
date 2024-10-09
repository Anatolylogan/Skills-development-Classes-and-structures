user tolya = new user();
string userName = tolya.name;
int userAge = tolya.age;
Console.WriteLine($"Имя:{userName} Возраст:{userAge}");

tolya.name = "Tolya";
tolya.age = 22;
tolya.Main();
class user
{
    public string name = "Tolya";
    public int age = 22;
 
   public void Main()
  {
   Console.WriteLine($"Имя:{name} Возраст:{age}");
  }
}