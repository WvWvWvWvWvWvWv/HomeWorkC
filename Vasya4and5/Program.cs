﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

void Chetnie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            System.Console.Write($"{array[i]} ");
        }
    }
}
void Nechetnie(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            System.Console.Write($"{array[i]} ");
        }
    }
}
string Bolshe4ILI5(int[] array)
{
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] % 2 == 0)
        {
            count1 += 1;
        }
        if (array[i] % 2 != 0)
        {
            count2 += 1;
        }
    }
    if (count1 >= count2)
    {
        return "Yes";
    }
    else
    {
        return "No";
    }

}




Console.Clear();
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
System.Console.WriteLine($"Дни, когда Василий получил оценки : [{string.Join(" , ", array)}]");
Console.WriteLine("Василий получил четверку в эти дни: ");
Chetnie(array);
Console.WriteLine(" \nВасилий получил тройку в эти дни: ");
Nechetnie(array);
System.Console.WriteLine($"\nМожет ли Василий рассчитывать на четверку?\n{Bolshe4ILI5(array)}");
//  Василий вполне может получить несколько оценок в один день, верно же?)


// По заданию,как я понял, дни тоже необходимо вводить с консоли. В этом случае верный код:

// void AddArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {   
//         System.Console.WriteLine($"В какой день Вася получил {i+1}ую оценку? ");
//         int den = int.Parse(Console.ReadLine());
//         while( den > 31 || den < 1)
//         {
//             System.Console.WriteLine($"В месяце 31 день), введите день: ");
//             den = int.Parse(Console.ReadLine());
//         }
//         array[i] = den;
//     }
// }

// void Chetnie(int [] array)
// {
//     for( int i = 0; i < array.Length; i++)
//     {
//         if ( array[i]%2==0)
//         {
//             System.Console.Write($"{array[i]} ");
//         }
//     }
// }
// void Nechetnie(int [] array)
// {
//     for( int i = 0; i < array.Length; i++)
//     {
//         if ( array[i]%2!=0)
//         {
//             System.Console.Write($"{array[i]} ");
//         }
//     }
// }
// string Bolshe4ILI5(int[] array)
// {   int count1=0;
//     int count2=0;
//     for (int i = 0; i < array.Length; i++)

//     {
//         if (array[i]%2==0)
//         {   
//             count1+=1;
//         }
//         if (array[i]%2!=0)
//         {   
//             count2+=1;
//         }
//     }
//     if(count1>=count2)
//     {
//         return "Yes";
//     }
//     else
//     {
//     return "No";
//     }

// }
// Console.Clear();
// System.Console.WriteLine("Сколько оценок получил Вася? ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];
// AddArray(array);
// System.Console.WriteLine($"Дни, когда Василий получил оценки : [{string.Join(" , " , array)}]");
// Console.WriteLine("Василий получил четверку в эти дни: ");
// Chetnie(array);
// Console.WriteLine(" \nВасилий получил тройку в эти дни: ");
// Nechetnie(array);
// System.Console.WriteLine($"\nМожет ли Василий рассчитывать на четверку?\n{Bolshe4ILI5(array)}");
