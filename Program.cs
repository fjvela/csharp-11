// See https://aka.ms/new-console-template for more information

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