// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");
void ListPatterns()
{
    Console.WriteLine("** List Patterns **");

    int CheckSwitch(int[] values) => values switch
    {
        //The discard pattern(_) matches any single element,
        //The new range pattern(..) matches any sequence of zero or more elements
        [1, 2, .., 10] => 1,
        [1, 2] => 2,
        [1, _] => 3,
        [1, ..] => 4,
        [21] => 5,
        [21, _, ..] => 6,
        [33, _, 34, .., 44] => 7,
        [_, ..] => 50
    };

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

ListPatterns();


int[] numbers = { 1, 5, 6 };

Console.WriteLine(numbers is [1, ..]);
Console.WriteLine(numbers is [1, 5, 98, 12]);
Console.WriteLine(numbers is [0 or 1 , <= 5, 98, 12]);


if (numbers is [var first, _, _])
{
    Console.WriteLine($"The first element of a three-item list is {first}.");
}


if (numbers is [1, var second, _])
{
    Console.WriteLine($"The second element of a three-item list is {second}.");
}


Console.ReadLine();