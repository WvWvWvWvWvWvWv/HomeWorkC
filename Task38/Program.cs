//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100 + 0, 2);
}
double Max(double[]array)
{
    double max = array[0];
    for (int i = 0; i <array.Length; i++)
    {
        if (max<array[i])
        {
            max=array[i];
        }
    }
    return max;
}
double Min(double[]array)
{
    double min = array[0];
    for (int i = 0; i <array.Length; i++)
    {
        if (min>array[i])
        {
            min=array[i];
        }
    }
    return min;
}

Console.Clear();
double[] array = new double[5];
InputArray(array);
System.Console.WriteLine($"array: [{string.Join(" , " , array)}]");
System.Console.WriteLine($"Max {Max(array)} - Min {Min(array)} = {Max(array)-Min(array)}");