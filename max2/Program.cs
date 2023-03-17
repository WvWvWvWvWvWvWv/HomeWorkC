Console.Clear();
int n =  int.Parse(Console.ReadLine()!), max1=n, max2=0;
while ( n!=0)
{
    n = int.Parse(Console.ReadLine()!);
    if(n>max1)
    {
        max2=max1;
        max1=n;

    }
    else if (n>max2)
    {
        max2=n;
    }
}
System.Console.WriteLine("max = " + max2);