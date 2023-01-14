
void RawStrings()
{
    Console.WriteLine("** Raw string literals **");

    var myStringScaped = "<element attr=\"content\"/>";

    var myString = @"
          <element attr=""content""/>";

    var myStringRaw = """
          <element attr="content"/>
          """;

    var myJSONRaw = """
        {
            "name": "Javi Vela"
            }
        """;

    var name = "Javi Vela";

    var myJSONRawInterpolated = $$"""
        {
            "name": "{{name}}"
        }
        """;

    Console.WriteLine(myStringScaped);
    Console.WriteLine(myStringRaw);
    Console.WriteLine(myString);
    Console.WriteLine(myJSONRaw);
    Console.WriteLine(myJSONRawInterpolated);

    Console.WriteLine("** End raw string literals **");
}


Console.WriteLine("Hello human!");
RawStrings();
Console.ReadLine();