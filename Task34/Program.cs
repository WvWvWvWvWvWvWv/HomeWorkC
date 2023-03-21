//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100 , 1000);
}
int Chetnost(int[] array)
{
    int count=0;
    for(int i = 0;i<array.Length;i++)
    {   if(array[i]%2==0){
        count+=1;}
    }
    return count;
}




Console.Clear();
int[] array = new int[10];
InputArray(array);
System.Console.WriteLine($"array: [{string.Join(" , " , array)}]");
System.Console.WriteLine($"Четных чисел: {Chetnost(array)}");