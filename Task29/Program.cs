Console.Clear();
int [] array = new int[8];
Random random = new Random();
int i = 0;
while (i < array.Length){
    array[i]=random.Next(0,10);
    Console.Write($"{array[i]}, ");
    i++;
}
