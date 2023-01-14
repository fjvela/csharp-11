// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");
Console.WriteLine("** Generic math support **");

int AddAll(int[] items)
{
    var result = 0;
    foreach (var item in items)
        result += item;
    return result;
}

int[] numbers = new[] { 1, 5, 6, 9, 19};

Console.WriteLine(AddAll(numbers));

Console.WriteLine("** end generic math support **");

Console.ReadLine();