// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int som(int x, int y)
{
    return x + y;
}

Console.WriteLine($"2 + 3 = {som(2, 3)}");

bool sup(int x, int y)
{
    return x >= y 
        ? true 
        : false;
}

Console.WriteLine($"6 >= 3 = {sup(6, 3)}");

int opposer(int x)
{
    return -x;
}

Console.WriteLine($"l'opposé de 7 = {opposer(7)}");

