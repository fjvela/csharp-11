// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello human!");


var data = Enumerable.Range(100, 2000);

int Sum()
{
    return data.Where(x => Filter(x)).Sum();
}

int SumMethodGroup()
{ // C#10 doesn't optimized
    return data.Where(Filter).Sum();
}

bool Filter(int value) {
    return value > 1000;
}