Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int max = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    if (max < array[i - 1] + array[i] + array[i + 1])
        max = array[i - 1] + array[i] + array[i + 1];
}
if (max < array[array.Length - 1] + array[array.Length - 2] + array[0])
    max = array[array.Length - 1] + array[array.Length - 2] + array[0];

if (max < array[array.Length - 1] + array[0] + array[1])
    max = array[array.Length - 1] + array[0] + array[1];
Console.WriteLine(max);