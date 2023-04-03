// Не решил.
void ZapolnenieMatrix(int[,] matrix)
{
    int i = 0, j = 0, value = 0;
    for (int d = 0; d < matrix.GetLength(0); d++)
    {
        i = 0;
        j = d;

        while (j >= 0)
        {
            matrix[i, j] = value;
            value++; i++; j--;
        }
    }
    j = matrix.GetLength(1) - 1;
    for (int d = 1; d < matrix.GetLength(0); d++)
    {
        i = d;
        while (j >= 1)
        {
            matrix[i, j] = value;
            value++; i++; j--;
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





Console.Clear();
System.Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
ZapolnenieMatrix(matrix);
PrintMatrix(matrix);