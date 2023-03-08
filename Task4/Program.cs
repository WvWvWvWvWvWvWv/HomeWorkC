Console.Clear();
Console.WriteLine("Введите число");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
if (z>x)
{
    if(z>c)
    Console.WriteLine("max " + z);
}
if( x>z)
{   
    if(x>c)
    Console.WriteLine("max " + x);
}
if (c>x)
{
    if(c>z)
    Console.WriteLine("max " + c);

}

        


