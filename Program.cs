// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");
void SimplifiedParameterNullValidationCode()
{
    Console.WriteLine("** Simplified parameter null validation code (!!) **");

    void MyAwesomeMethod(string mystring!!)
    {
    }

    try
    {
        MyAwesomeMethod(null);
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Simplified parameter null validation code (!!): ex catched");
    }

    Console.WriteLine("** End Simplified parameter null validation code (!!) **");
}

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
            2.- Simplified parameter null validation code (!!)
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
        case "2":
            SimplifiedParameterNullValidationCode();
            break;
    }
} while (option != "0");