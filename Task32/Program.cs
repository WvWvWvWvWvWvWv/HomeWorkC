void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9; 9]
}
void Zamena(int [] array)
{   int [] array2=array;
    for(int i = 0; i<array.Length; i++)
    {
        array[i]*=(-1);
    }
}
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Zamena(array);
System.Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");