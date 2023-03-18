Console.Clear();
System.Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while(i>0){
    int a = i%10;
    sum+=a;
    i/=10;
}
System.Console.WriteLine(sum);