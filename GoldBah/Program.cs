Console.Clear();
System.Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int random=new Random().Next(); // int random=new Random().Next(0,n) , но по сути правильнее так конечно.
System.Console.WriteLine($"{n-random} + {random} = {n}");