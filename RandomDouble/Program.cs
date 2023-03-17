Console.Clear();
System.Console.WriteLine("Vvedite chislo: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
// ... = new Random.NextDouble() * 9end - begin) +begin
for ( int i = 0 ; i < array.Length; i++){
    array[i] = Math.Round(new Random().NextDouble() * (30-10) + 10, 2);
}
System.Console.WriteLine($"[{string.Join(", " , array)}]");