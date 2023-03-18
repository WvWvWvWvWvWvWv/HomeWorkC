Console.Clear();
int []array={5,3,7,4,6};
System.Console.WriteLine("Vvedite chislo: ");
int K = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int box = 0;
int l = array.Length;
// if(K>0){
//     while (K>j){
//     i=0;
//     while(i<1){
//         box=array[l-1];
//         array[i+4]=array[i+3];
//         array[i+3]=array[i+2];
//         array[i+2]=array[i+1];
//         array[i+1]=array[i];
//         array[i]=box;
//         i++;}
//      j++;}}
// if(K<0){
//     while(K<j){
//         i=0;
//         while(i<1){
//         box=array[0];
//         array[i]=array[i+1];
//         array[i+1]=array[i+2];
//         array[i+2]=array[i+3];
//         array[i+3]=array[i+4];
//         array[l-1]=box;
//         i++;}
//         j--;}}
while(K>j){
    i=0;
    box=array[l-1];
    while(i<l-1){
        array[l-1-i]=array[l-2-i];
        i++;
    }
    array[0]=box;
    j++;
}
 
i=0;
while(i<array.Length){
    Console.Write(array[i] + ", ");
    i++;
}