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


RawStrings();

Console.WriteLine("End");
Console.ReadLine();