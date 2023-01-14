// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");
Console.WriteLine("** Required modifier **");


var user = new User
{
    Name = "Javi Vela"
};

//user.Name = "Javi Vela";

Console.WriteLine($"Name: {user.Name}");

Console.WriteLine("** end required modifier **");
Console.ReadLine();

class User
{
    public required string Name { get; init; }
}
