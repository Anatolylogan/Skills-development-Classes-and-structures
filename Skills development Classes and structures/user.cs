struct Address(string city, string street)
{
  public void Print() => Console.WriteLine($"Город: {city}  Улица: {street}");
}
class User
{
 public string name;
 public int age;
 public User() { name = "Неизвестно"; age = 1; }
 public User(string n, int a) { name = n; age = a; }
 public void Print() => Console.WriteLine($"Имя:{name} Возраст:{age}");
}
