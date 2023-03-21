void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); // [-100; 100]
}
int SkolkoChisel(int[] array)
{
    int sum = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if(array[i]>=10 && array[i]<=99)
        sum+=1;
    }
    return sum;
}





Console.Clear();
int[] array = new int[123];
InputArray(array);
SkolkoChisel(array);
Console.WriteLine($"Кол-во чисел от 10 до 99 : {SkolkoChisel(array)}");
