// Необходимо сложить 2 числа с помощью рекурсии.

int f(int a, int b)
{
    if (a == 0)
        return b;
    return f(a - 1, b + 1);
}
Console.Clear();
System.Console.WriteLine(f(5, 3));

// f(5,3) -> f(4,4) -> f(3,5) ... -> f(0,8) return b -> 8