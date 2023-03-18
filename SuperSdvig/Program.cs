Console.Clear();
int []array={5,3,7,4,6};
System.Console.WriteLine("Vvedite chislo: ");
int K = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int box;
int l = array.Length;
if(K>0){
    while (K>j){
    i=0;
    while(i<1){
        box=array[l-1];
        array[i+4]=array[i+3];
        array[i+3]=array[i+2];
        array[i+2]=array[i+1];
        array[i+1]=array[i];
        array[i]=box;
        i++;}
     j++;}}
if(K<0){
    while(K<j){
        i=0;
        while(i<1){
        box=array[0];
        array[i]=array[i+1];
        array[i+1]=array[i+2];
        array[i+2]=array[i+3];
        array[i+3]=array[i+4];
        array[l-1]=box;
        i++;}
        j--;}}
 
Console.Write($"{array[0]},{array[1]},{array[2]},{array[3]},{array[4]}");