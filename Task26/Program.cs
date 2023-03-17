Console.Clear();
System.Console.WriteLine("Vvedite chislo: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int a = 1;
while ( n>9){
    n/=10;
    a++;

}
System.Console.WriteLine(a);