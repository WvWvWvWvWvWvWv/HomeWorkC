//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такой позиции нет.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");

        }
        System.Console.WriteLine();
    }
}
void ProverkaNalichiyaElementa(int[,] matrix)
{
    System.Console.WriteLine("Введите позицию элемента: ");
    int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    if (position[0] > matrix.GetLength(0) - 1 || position[1] > matrix.GetLength(1) - 1)
    {
        System.Console.WriteLine("Такой позиции нет");
    }
    else
    {
        System.Console.WriteLine(matrix[position[0], position[1]]);
    }
}
Console.Clear();
System.Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ProverkaNalichiyaElementa(matrix);