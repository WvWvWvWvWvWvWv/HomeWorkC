// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 5);
//         }
//     }
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} \t");

//         }
//         System.Console.WriteLine();
//     }
// }
// void Slovar(int[,] matrix, int c)
// {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == c)
//             {
//                 count++;
//             }
//         }
//     }
//     System.Console.WriteLine($"{c} встречается {count} раз");
// }
// Console.Clear();
// System.Console.Write("Введите размерность массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// for (int c = 0; c < 5; c++)
// {
//     Slovar(matrix, c);
// }

bool checkElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return false;
    }
    return true;
}

int inputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            if (checkElement(array, matrix[i, j]))
            {
                array[k] = matrix[i, j];
                k++;
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return k;
}


void SwapFirstLastString(int[,] matrix, int[] array, int countArray)
{
    for (int k = 0; k < countArray; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
    }

}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[] array = new int[coord[0] * coord[1]];
Console.WriteLine("Начальный массив: ");
int countArray = inputMatrix(matrix, array);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");
SwapFirstLastString(matrix, array, countArray);