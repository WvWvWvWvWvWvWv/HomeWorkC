Console.Clear();
System.Console.WriteLine("Введите пятизначное число : ");
int a = Convert.ToInt32(Console.ReadLine());
while (a<10000 || a>99999){
    Console.Write("Вы ошиблись!\nВведите пятизначное число : ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a/10000%10==a%10 || a/1000%10==a/10%10){
    System.Console.WriteLine("True");
}
else
    System.Console.WriteLine("False");