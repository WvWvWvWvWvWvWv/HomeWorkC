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
void Transportirovanie(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int box = matrix[i, j];
            matrix[i, j] = matrix[i + 2, j];
            matrix[i + 2, j] = box;
        }

    }
}
void Transportirovanie2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int box = matrix[i, j];
            matrix[i, j] = matrix[i + 1, j];
            matrix[i + 1, j] = box;
        }

    }
}
Console.Clear();
System.Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
if (size[0] == 2)
{
    Transportirovanie2(matrix);
}
else
{
    Transportirovanie(matrix);
}
System.Console.WriteLine();
PrintMatrix(matrix);