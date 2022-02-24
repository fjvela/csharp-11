// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");

void RawStrings()
{
    Console.WriteLine("** Raw string literals **");
    var myStringRaw = """
          <element attr="content"/>
          """;
    var myString = @"
          <element attr=""content""/>";
    Console.WriteLine(myStringRaw);
    Console.WriteLine(myString);
    Console.WriteLine("** End raw string literals **");
}

void PrintMenu()
{
    Console.WriteLine();
    Console.Write(
        """
        Menu:
            1.- Raw strings
            0.- Exit
        Option:
        """);
}

string? option;

do
{
    PrintMenu();
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            RawStrings();
            break;
    }
} while (option != "0");

Console.WriteLine("End");
Console.ReadLine();