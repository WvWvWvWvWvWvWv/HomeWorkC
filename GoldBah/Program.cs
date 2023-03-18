Console.Clear();
System.Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int random=new Random().Next(1,n);
System.Console.WriteLine($"{n-random} + {random} = {n}");