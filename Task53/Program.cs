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
void Zamena(int[,] matrix)
{
    int box;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        box = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(1) - 1, j];
        matrix[matrix.GetLength(1) - 1, j] = box;
    }
}



Console.Clear();
System.Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Zamena(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);