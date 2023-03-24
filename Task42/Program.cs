Console.Clear();
System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string a2=string.Empty;
while (a>0)
{
    a2=Convert.ToString(a%2)+a2;
    a/=2;
}
    
System.Console.WriteLine(a2);


//////////////// через разрядность
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 0, count = 1;
// while (n > 0)
// {
//     result += (n % 2) * count;
//     n /= 2;
//     count *= 10;
// }
// Console.WriteLine(result);
