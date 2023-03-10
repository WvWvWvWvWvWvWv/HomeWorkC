Console.Clear();
Console.WriteLine("Введите номер дня недели : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>5)
    Console.WriteLine("Выходной!");
else
    Console.WriteLine("Рабочий день");