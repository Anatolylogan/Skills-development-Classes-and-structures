namespace Skills_development_Classes_and_structures;

public struct Address
{
    public string City;
    public string Street;

    public Address(string c, string s)
    {
        City = c;
        Street = s;
    }

    public void Print() => Console.WriteLine($"Адресс:{City},{Street}");
}
