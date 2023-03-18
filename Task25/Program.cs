Console.Clear();
System.Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("В какую степень желаете возвести? : ");
int y = Convert.ToInt32(Console.ReadLine());
int i = 1;
int z= x;
while ( i < y){
    z=z*x;
    i++;
}

System.Console.WriteLine(z);