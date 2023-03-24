void AddArray(int[] array)
{
    for (int i = 2; i < array.Length; i++)
    {   
        array[0]=0;
        array[1]=1;
        array[i]=array[i-2]+array[i-1];
    
    }
}


Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
AddArray(array);

Console.WriteLine($"[{string.Join(", ", array)}]");