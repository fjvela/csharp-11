// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello human!");
Console.WriteLine("** Auto-default struct **");


var position = new Position(1, 2);

Debugger.Break();
Console.Read();
struct Position
{
    public int X;
    public int Y;
    
    public Position(int x, int y)
    {
        this.X = x;
    }
}


