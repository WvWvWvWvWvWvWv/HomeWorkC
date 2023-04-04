string f(int n, int m)
{
    if (n == m)
        return $"{m} ";
    return f(n - 1, m) + $"{n} ";
}


Console.Clear();
System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число меньше: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(f(n, m));
