int f(int a, int b)
{
    if (b == 0)
        return 1;
    if (b == 1)
        return a;
    return f(a, b - 1) * a;


}

Console.Clear();
System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("В какую степень возвести: ");
int b = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(f(a, b));