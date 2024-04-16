class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var lista = new List<string>
        {
            "sla",
            "sim"
        };

        var users = new List<User>
        {
            new("André", 17),
            new("Rian", 15)
        };

        var algo = lista.FindAll(x => x[0] == 's');

        Console.WriteLine(algo[0]);

        foreach (var i in lista)
            Console.WriteLine(i);

        var andre = users.Find(user => user.Name == "André");

        Console.WriteLine(andre?.Name);
        Console.WriteLine(andre?.Age);

        foreach (var user in users)
            Console.WriteLine($"Nome: {user.Name}, idade: {user.Age}");
    }
}

class User
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age; ;
    }
}