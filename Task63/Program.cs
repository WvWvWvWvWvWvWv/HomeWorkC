string f(int n)
{
    if (n == 1)
        return "1 ";
    return f(n - 1) + $"{n} ";
}


Console.Clear();
System.Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(f(n));
/*
f(5) -> f(4) + "5 "
          |
          f(3) + "4 "
            |
            f(2) + "3 "
              |
              f(1) + "2 "
                |
                "1 "
*/