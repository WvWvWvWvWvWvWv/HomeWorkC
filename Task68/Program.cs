//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Ak(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
        return Ak(m - 1, 1);
    else
    {
        return (Ak(m - 1, Ak(m, n - 1)));
    }


}



Console.Clear();
System.Console.Write("Введите неотрицательное число: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите неотрицательное число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Ak(m, n));
