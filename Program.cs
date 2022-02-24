// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");
void ListPatterns()
{
    int CheckSwitch(int[] values) => values switch
    {
        [1, 2, .., 10] => 1,
        [1, 2] => 2,
        [1, _] => 3,
        [1, ..] => 4,
        [21] => 5,
        [21, _, ..] => 6,
        [33, _, 34, .., 44] => 7,
        [_, ..] => 50
    };
    Console.WriteLine("** List patterns **");

    Console.WriteLine(CheckSwitch(new[] { 1, 2, 10 }));                 // prints 1
    Console.WriteLine(CheckSwitch(new[] { 1, 2, 7, 3, 3, 10 }));        // prints 1
    Console.WriteLine(CheckSwitch(new[] { 1, 2 }));                     // prints 2
    Console.WriteLine(CheckSwitch(new[] { 1, 3 }));                     // prints 3
    Console.WriteLine(CheckSwitch(new[] { 1, 3, 5 }));                  // prints 4
    Console.WriteLine(CheckSwitch(new[] { 2, 5, 6, 7 }));               // prints 50
    Console.WriteLine(CheckSwitch(new[] { 21, 52, 63, 74, 5 }));        // prints 5
    Console.WriteLine(CheckSwitch(new[] { 21 }));                       // prints 6
    Console.WriteLine(CheckSwitch(new[] { 33, 0, 34, 1, 2, 3, 44 }));   // prints 7

    Console.WriteLine("** End list patterns **");
}

void SimplifiedParameterNullValidationCode()
{
    Console.WriteLine("** Simplified parameter null validation code (!!) **");

    void MyAwesomeMethod(string mystring!!)
    {
    }

    void WarnCase<T>(
        string? name!!,     // CS8995 Nullable type 'string?' is null-checked and will throw if null.
        T value1!!          // Okay
     )
    { }

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
            3.- List patterns
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

        case "3":
            ListPatterns();
            break;
    };
} while (option != "0");