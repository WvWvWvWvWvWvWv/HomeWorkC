Console.Clear();
System.Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int random=new Random().Next(1,n);
int y = n-random;
System.Console.WriteLine($"{y} + {random} = {n}");