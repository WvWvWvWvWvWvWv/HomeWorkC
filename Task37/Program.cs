void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}
int Proizdedeine(int[] array)
{
    int f = 0;
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
        Console.WriteLine($"Произведение парных чисел: {array[i] * array[array.Length - 1 - i]}");
    }
    return f;
}


Console.Clear();
int[] array = new int[5];
InputArray(array);
System.Console.WriteLine($"array: [{string.Join(" , ", array)}]");
Proizdedeine(array);
