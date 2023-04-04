int f(int n)
{
    if (n < 10)
        return n;
    return f(n / 10) + n % 10;


}

Console.Clear();
System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(f(n));