Console.Clear();
Console.Write("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
    Console.WriteLine("3 цифры нет, введите трехзначное число!");
while (a>1000)
     a=a/10;
    Console.WriteLine(a%10);