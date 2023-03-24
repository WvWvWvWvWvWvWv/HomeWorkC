Console.Clear();
System.Console.WriteLine("Введите длину 1 стороны: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите длину 2 стороны: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите длину 3 стороны: ");
int c = int.Parse(Console.ReadLine()!);
if (a<b+c && b<a+c && c<a+b )
{
    System.Console.WriteLine("Такой треугольник может существовать");
}
else 
System.Console.WriteLine("Такой треугольник не может существовать");