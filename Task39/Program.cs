void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReplaceElements(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] a = new int[n];
InputArray(a);
Console.WriteLine($"Начальный массив: [{string.Join(", ", a)}]");
ReplaceElements(a);
Console.WriteLine($"Конечный массив: [{string.Join(", ", a)}]");