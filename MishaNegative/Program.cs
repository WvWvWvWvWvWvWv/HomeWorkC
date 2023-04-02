void InputMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("[" + i + "," + j + "]: ");
            matrix[i, j] = (Console.ReadLine());
        }
    }
}
void PrintMatrix(string[,] matrix)
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
int Sravnenie(string[,] matrix, string[,] matrix1)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == matrix1[i, j])
            {
                count++;
            }


        }
    }
    return count;
}
System.Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
string[,] matrix = new string[size[0], size[1]];
string[,] matrix1 = new string[size[0], size[1]];
System.Console.WriteLine("Введите B или W для первой матрицы: ");
InputMatrix(matrix);
System.Console.WriteLine("Введите B или W для второй матрицы: ");
InputMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(matrix1);
System.Console.WriteLine();
System.Console.WriteLine($"Ошибок: {Sravnenie(matrix, matrix1)}");
