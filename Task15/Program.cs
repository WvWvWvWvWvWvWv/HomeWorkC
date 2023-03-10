Console.Clear();
Console.WriteLine("Введите номер дня недели : ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>7)
    Console.WriteLine("Вообще-то в неделе 7 дней :)");
if (a==6 || a==7)
    Console.WriteLine("Выходной!");
if (a<=5)
    Console.WriteLine("Рабочий день");